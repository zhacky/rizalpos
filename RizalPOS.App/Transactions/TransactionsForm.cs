using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using RizalPOS.Domain.Classes;
using RizalPOS.Domain.Context;

namespace RizalPOS.App.Transactions
{
    public partial class TransactionsForm : MetroForm
    {
        // -- context
        private PosContext context;
        // -- ticket binding source
        private BindingSource ticketBindingSource;
        private BindingSource ticketlineBindingSource;
        // -- ticketlines
        private List<TicketLine> ticketlines;

        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            context = new PosContext();
            ticketBindingSource = new BindingSource();
            ticketlineBindingSource = new BindingSource();
            ticketBindingSource.DataSource = context.Tickets.ToList();
            ticketlines = new List<TicketLine>();
            RefreshTickets();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshTickets();
        }

        private void RefreshTickets()
        {
            // -- display list
            SetTicketDataSource();
            SetTicketlineDataSource();
            DisplayTransactionGridColumns();
            DisplayTicketlineGridColumns();


        }

        private void SetTicketDataSource()
        {
            ticketBindingSource.DataSource =
                context.Tickets.Where(
                    c => c.TransactDate > TransactionDateTime.Value && c.TransactDate < TransactionToDateTime.Value)
                    .ToList();
            TransactionGrid.DataSource = ticketBindingSource;
        }

        private void SetTicketlineDataSource()
        {
            var ticket = ticketBindingSource.Current as Ticket;
            if (ticket != null)
            {
                var lines = context.Ticketlines.Where(c => c.TicketId == ticket.Id).ToList();
                TicketlineGrid.DataSource = lines;
            }
        }

        private void DisplayTicketlineGridColumns()
        {
          // -- id
            var idColumn = TicketlineGrid.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;
          // -- ticket
            var ticketColumn = TicketlineGrid.Columns["TicketId"];
            if (ticketColumn != null) ticketColumn.Visible = false;
        }

        private void DisplayTransactionGridColumns()
        {
            
            // -- id
            var idColumn = TransactionGrid.Columns["Id"];
            if (idColumn != null) idColumn.Visible = false;
            // -- user
            var userColumn = TransactionGrid.Columns["User"];
            if (userColumn != null)
            {
                userColumn.Visible = false;
                }
            // -- customer
            var custColumn = TransactionGrid.Columns["Customer"];
            if (custColumn != null) custColumn.Visible = false;
            //------------------visible------------//
            // -- transactdate
            var dateColumn = TransactionGrid.Columns["TransactDate"];
            if (dateColumn != null)
            {
                dateColumn.DefaultCellStyle.Format = "g";
                dateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dateColumn.HeaderText = "Date";
            }
            // -- totalamount
            var totalColumn = TransactionGrid.Columns["TotalAmount"];
            if (totalColumn != null)
            {
                totalColumn.HeaderText = "Amount";
                totalColumn.Width = 50;
                totalColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                totalColumn.DefaultCellStyle.Format = "#,##0.00";
            }
            // -- cashgiven
            var cashColumn = TransactionGrid.Columns["CashGiven"];
            if (cashColumn != null)
            {
                cashColumn.HeaderText = "Cash";
                cashColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                cashColumn.Width = 50;
                cashColumn.DefaultCellStyle.Format = "#,##0.00";
            }
            // -- changereceived
            var changeColumn = TransactionGrid.Columns["ChangeReceived"];
            if (changeColumn != null)
            {
                changeColumn.HeaderText = "Change";
                changeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                changeColumn.Width = 50;
                changeColumn.DefaultCellStyle.Format = "#,##0.00";
            }
        }

        private void TransactionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshTickets();
        }

      


        private void CheckTimeDifference(int datepicker_type)
        {
            if (TransactionToDateTime.Value < TransactionDateTime.Value)
            {
                MessageBox.Show("From-date must be lesser than To-date");
            }

            switch (datepicker_type)
            {
                case 1:
                    if(TransactionToDateTime.Value < TransactionDateTime.Value)
                TransactionDateTime.Value = TransactionToDateTime.Value;
                    break;
                case 2:
                    if (TransactionToDateTime.Value < TransactionDateTime.Value)
                TransactionToDateTime.Value = TransactionDateTime.Value;
                    break;
            }




        }

        private void TransactionDateTime_Leave(object sender, EventArgs e)
        {
            CheckTimeDifference(1);
        }

        private void TransactionToDateTime_Leave(object sender, EventArgs e)
        {
            CheckTimeDifference(2);
        }

        private void TransactionToDateTime_ValueChanged(object sender, EventArgs e)
        {
            CheckTimeDifference(2);
        }

        private void TransactionDateTime_ValueChanged(object sender, EventArgs e)
        {
            CheckTimeDifference(1);
        }


    }
}
