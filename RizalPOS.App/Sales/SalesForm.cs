using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using RizalPOS.App.Customers;
using RizalPOS.App.Management;
using RizalPOS.App.Products;
using RizalPOS.App.Properties;
using RizalPOS.Domain.Classes;
using RizalPOS.Domain.Context;

namespace RizalPOS.App.Sales
{
    public partial class SalesForm : MetroForm
    {
        #region Fields:


        private double TotalCash;
        private PosContext context;
        private Ticket ticket;
        private List<TicketLine> ticketlines;
        private BindingSource ticketlineBindingSource;
        private Font printFont;
        private Font creditFont;
        private Font receiptFont;
        private Brush gray;
        private int ReceiptNo;
        private int receiptWidth;
        #endregion

        #region Methods:

        private void InitAll()
        {
            //--set icon
            Icon = Resources.shopping_cart;
            //--align numeric textboxes
            TotalAmountTextBox.TextAlign = HorizontalAlignment.Right;
            TotalAmountTextBox.RightToLeft = RightToLeft.No;
            CashAmountTextBox.TextAlign = HorizontalAlignment.Right;
            CashAmountTextBox.RightToLeft = RightToLeft.No;
            ChangeAmountTextBox.TextAlign = HorizontalAlignment.Right;
            ChangeAmountTextBox.RightToLeft = RightToLeft.No;
            //--set default input
            TotalAmountTextBox.Text = (0).ToString("#,##0.00");
            CashAmountTextBox.Text = (0).ToString("#,##0.00");
            ChangeAmountTextBox.Text = (0).ToString("#,##0.00");
            BarcodeInputTextBox.Clear();
            //--set appearance
            TotalAmountTextBox.ForeColor = Color.FromArgb(0, 174, 219);
            CashAmountTextBox.ForeColor = Color.FromArgb(0, 174, 219);
            ChangeAmountTextBox.ForeColor = Color.FromArgb(0, 174, 219);
            //--change button text colors
            ItemButton.Style = MetroColorStyle.Blue;
            StocksButton.Style = MetroColorStyle.Blue;
            MenuButton.Style = MetroColorStyle.Blue;
            VoidButton.Style = MetroColorStyle.Blue;
            PayButton.Style = MetroColorStyle.Blue;
            //--set shortcuts
        }
        private void NewTicket()
        {
            ticket = new Ticket();

            ticket.Customer = context.Customers.FirstOrDefault();
            ticketlines = new List<TicketLine>();
            ticketlineBindingSource = new BindingSource();
            //--set to grid
            ticketlineBindingSource.DataSource = ticketlines;
            ItemTenderGrid.DataSource = ticketlineBindingSource;
        }
        private void InitItemTenderGrid()
        {
            // -- Item Column
            ItemTenderGrid.Columns[0].Visible = false;
            ItemTenderGrid.Columns[1].Visible = false;
            ItemTenderGrid.Columns[2].Visible = false;
            var itemColumn = ItemTenderGrid.Columns["ItemName"];
            if (itemColumn != null)
            {
                itemColumn.HeaderText = @"Item";
                itemColumn.FillWeight = .65f;
                itemColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                itemColumn.DefaultCellStyle = new DataGridViewCellStyle { WrapMode = DataGridViewTriState.True };
            }
            // -- Price Column
            var priceColumn = ItemTenderGrid.Columns["ItemPrice"];
            if (priceColumn != null)
            {
                priceColumn.HeaderText = @"Price";
                priceColumn.FillWeight = .2f;
                priceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                priceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                priceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                priceColumn.DefaultCellStyle.Format = "#,##0.00";
            }
            // -- Quantity Column
            var qtyColumn = ItemTenderGrid.Columns["Quantity"];
            if (qtyColumn != null)
            {
                qtyColumn.FillWeight = .15f;
                qtyColumn.HeaderText = @"Qty";
                qtyColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                qtyColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                qtyColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            // -- Amount Column
            var amountColumn = ItemTenderGrid.Columns["TotalAmount"];
            if (amountColumn != null)
            {
                amountColumn.FillWeight = .2f;
                amountColumn.HeaderText = @"Amount";
                amountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                amountColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                amountColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                amountColumn.DefaultCellStyle.Format = "#,##0.00";
            }

        }
        private void InputBarcodeItem()
        {
            var barcode = BarcodeInputTextBox.Text.Trim();
            var product = SearchBarcode(barcode);
            if (product != null)
            {
                AddProduct(product, 1);
                BarcodeInputTextBox.Clear();
            }
        }
        private Product SearchBarcode(string barcode)
        {
            Product product = context.Products.FirstOrDefault(p => p.Barcode == barcode);
            if (product != null)
            {
                return product;
            }
            return null;
        }
        private void AddProduct(Product product, double quantity)
        {
            var ticketline = new TicketLine();
            //--populate ticketline with product
            ticketline.ProductId = product.Id;
            ticketline.ItemName = product.Name;
            ticketline.ItemPrice = product.UnitPrice;
            ticketline.Quantity = quantity;
            ticketline.TotalAmount = product.UnitPrice * quantity;
            ticketlineBindingSource.Add(ticketline);
            ItemTenderGrid.DataSource = ticketlineBindingSource;
            ticketlineBindingSource.MoveLast();

        }
        private double CheckTotal()
        {
            if (ticketlineBindingSource.Count > 0)
            {
                double totalAmount = 0;
                foreach (TicketLine line in ticketlineBindingSource.List)
                {
                    if (line != null)
                    {
                        line.TotalAmount = line.Quantity * line.ItemPrice;
                        totalAmount += line.TotalAmount;
                    }
                }
                TotalAmountTextBox.Text = totalAmount.ToString("#,##0.00");
                return totalAmount;
            }
            else
            {
                return 0;
            }
        }
        private void CreateNewTransaction()
        {
            if (ticketlineBindingSource != null && ticketlineBindingSource.Count > 0)
            {
                NewTicket();
            }
            TotalCash = 0;
            //-- clear amount boxes
            TotalAmountTextBox.Text = DisplayAmountAsText(0);
            CashAmountTextBox.Text = DisplayAmountAsText(0);
            ChangeAmountTextBox.Text = DisplayAmountAsText(0);
            //-- clear customer
            CustomerTextBox.Clear();
            CustomerCodeTextBox.Clear();
            //-- clear barcode
            BarcodeInputTextBox.Clear();

        }
        private void CalculateTransaction()
        {
            CashAmountTextBox.Text = DisplayAmountAsText(TotalCash);

        }
        private string DisplayAmountAsText(double amount)
        {
            return amount.ToString("#,##0.00");
        }
        private void PayTransaction()
        {
            if (!(ticketlineBindingSource.Count > 0))
            {
                return;
            }
            var paymentForm = new PaymentForm { TotalAmount = CheckTotal() };

            var result = paymentForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                TotalCash = paymentForm.Payment;
                CalculateTransaction();
                ShowChangeAmount();
            }
        }
        private void ShowChangeAmount()
        {
            double totalAmount;
            if (double.TryParse(TotalAmountTextBox.Text, out totalAmount))
            {
                var changeForm = new ReturnChangeForm();
                changeForm.ShowInTaskbar = false;
                changeForm.Change = TotalCash - totalAmount;
                ChangeAmountTextBox.Text = DisplayAmountAsText(changeForm.Change);
                    PrintReceipt();
                var result = changeForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    AddToSales();
                    CreateNewTransaction();
                }
            }

        }

        private void AddToSales()
        {
            ticket.TicketLines = ticketlines;
            ticket.TransactDate = DateTime.Now;
            ticket.TotalAmount = double.Parse(TotalAmountTextBox.Text);
            ticket.CashGiven = double.Parse(CashAmountTextBox.Text);
            ticket.ChangeReceived = ticket.CashGiven - ticket.TotalAmount;
            context.Tickets.Add(ticket);
            context.SaveChanges();
            //TODO: add to tickets

        }

        private void PrintReceipt()
        {

            //TODO: print receipt
            var printDoc = new PrintDocument();
            printDoc.DocumentName = "Receipt";
            int pageHeight = 800;
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("Receipt",229, pageHeight);
            printDoc.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            printDoc.Print();
        }



        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageSettings.PaperSize.Height = 800;
            e.PageSettings.PaperSize.Width = 299;
            receiptWidth = 249;
            int row = 20;
            const int indent = 0;
            string header = "Rizal Merchandise";
            // --- header
            header += string.Format("{0}{1}", Environment.NewLine, "Quezon Ave. Marawi City");
            e.Graphics.DrawString(header, printFont, gray, (int)(Math.Floor((double) (receiptWidth/2))), row, new StringFormat { Alignment = StringAlignment.Center });
            // --- date
            string date = string.Format("{0}               {1}", DateTime.Today.ToShortDateString(), DateTime.Now.ToShortTimeString());
            e.Graphics.DrawString(date, receiptFont, gray, (int)(Math.Floor((double)(receiptWidth / 2))), (3 * row), new StringFormat { Alignment = StringAlignment.Center });
            e.Graphics.DrawLine(Pens.Gray, indent, (4 * row), receiptWidth-indent, (4 * row));
            string cashierInfo = string.Format("{1}{0}", Environment.NewLine, "Cashier: Admin");
            var line = ticketlineBindingSource.Current as TicketLine;
            ReceiptNo++;
            string recno = ReceiptNo.ToString("0000");
            if (line != null)
                cashierInfo += string.Format("Receipt No:{0}", recno);
                
            e.Graphics.DrawString(cashierInfo, receiptFont, gray, indent, (5 * row)-15);
            e.Graphics.DrawLine(Pens.Gray, indent, (6 * row) - 5, receiptWidth - indent, (6 * row) - 5);
            int lineNumber = 7;
            foreach (TicketLine ticketLine in ticketlineBindingSource)
            {
                string itemLine1 = "";
                string itemLine2 = "";
                string itemPrice = ticketLine.ItemPrice.ToString("#,##0.00");
                string itemQty = ticketLine.Quantity.ToString("###.#");
                string itemAmount = ticketLine.TotalAmount.ToString("#,##0.00");
                if (ticketLine.Quantity > 1)
                {
                    itemLine1 = ticketLine.ItemName;
                    itemLine2 = itemQty + "   1@" + itemPrice;
                    e.Graphics.DrawString(itemLine1, creditFont, gray, indent, lineNumber * row);
                    e.Graphics.DrawString(itemAmount, creditFont, gray, receiptWidth - indent, lineNumber * row, new StringFormat { Alignment = StringAlignment.Far });
                    lineNumber++;
                    e.Graphics.DrawString(itemLine2, creditFont, gray, indent, lineNumber * row);
                    
                }
                else
                {
                    itemLine1 = ticketLine.ItemName;
                    e.Graphics.DrawString(itemLine1, creditFont, gray, indent, lineNumber * row);
                    e.Graphics.DrawString(itemAmount, creditFont, gray, receiptWidth - indent, lineNumber * row, new StringFormat { Alignment = StringAlignment.Far });
                    
                }
                lineNumber++;

            }
            e.Graphics.DrawLine(Pens.Gray, indent, (lineNumber * row), receiptWidth - indent, (lineNumber * row));
            lineNumber++;
            e.Graphics.DrawString("Total ----------",receiptFont,gray,indent,(lineNumber*row));
            e.Graphics.DrawString(TotalAmountTextBox.Text,printFont,gray,100,(lineNumber*row));
            lineNumber++;
            e.Graphics.DrawString("Cash ----------", receiptFont, gray, indent, (lineNumber * row));
            e.Graphics.DrawString(CashAmountTextBox.Text,printFont,gray,100,(lineNumber*row));
            lineNumber++;
            e.Graphics.DrawString("Change ----------", receiptFont, gray, indent, (lineNumber * row));
            e.Graphics.DrawString(ChangeAmountTextBox.Text,printFont,gray,100,(lineNumber*row));
            lineNumber+=2;
            // --- 
            
            e.Graphics.DrawString("Thank you and please come again.",receiptFont,gray,40,lineNumber*row);
            lineNumber ++;
            //row = 10;
            e.Graphics.DrawString("Marawi Skynet | Ninja Tech Solutions | Remantec",creditFont,gray,20,lineNumber*row);
            lineNumber ++;
            e.Graphics.DrawString("Gomiza Ave. Marawi City",creditFont,gray,80,(lineNumber*row)-10);
            lineNumber ++;
            e.Graphics.DrawString("For info on POS systems, text: 0905-6150101",creditFont,gray,20,(lineNumber*row)-20);
            lineNumber ++;
            e.Graphics.DrawLine(Pens.Gray,100,lineNumber*row,200,lineNumber*row );
            e.PageSettings.PaperSize.Height = lineNumber*row;
        }

        private void DetectMdasItems()
        {
            if (BarcodeInputTextBox.Text.Contains("+") || BarcodeInputTextBox.Text.Contains("-"))
                BarcodeInputTextBox.Clear();

            if (BarcodeInputTextBox.Text.Contains("*"))
            {
                BarcodeInputTextBox.Clear();

                if (ticketlineBindingSource.Count > 0)
                {
                    MultiplierTextBox.Focus();
                    MultiplierTextBox.Text = @"x";
                    MultiplierTextBox.Select(MultiplierTextBox.Text.Length, 0);

                }
            }

        }
        private void ItemCommand()
        {
            var productlist = new ProductListDialog();
            if (productlist.ShowDialog(this) == DialogResult.OK)
            {
                var product = productlist.Product;
                var quantity = productlist.Quantity;
                AddProduct(product, quantity);
                CheckTotal();
            }
        }
        private void CheckQuantity()
        {
            if (ticketlineBindingSource.Count <= 0)
            {
                MessageBox.Show(@"Enter an item first.");
                BarcodeInputTextBox.Select();
                return;
            }
            if (!string.IsNullOrEmpty(MultiplierTextBox.Text))
            {
                var newString = MultiplierTextBox.Text.Contains("x") ? MultiplierTextBox.Text.Replace("x", "") : MultiplierTextBox.Text;
                double quantityCount;
                if (double.TryParse(newString, out quantityCount))
                {
                    var line = ticketlineBindingSource.Current as TicketLine;
                    if (line != null)
                    {
                        line.Quantity = quantityCount;
                        ticketlineBindingSource.ResetCurrentItem();
                        MultiplierTextBox.Clear();
                        BarcodeInputTextBox.Select();
                    }
                }
            }
            CheckTotal();

        }
        private void DeductQuantity()
        {

            var ticketline = ticketlineBindingSource.Current as TicketLine;
            if (ticketline != null)
            {
                if (ticketline.Quantity > 1)
                {
                    ticketline.Quantity -= 1;
                }
                else
                {
                    ticketlineBindingSource.RemoveCurrent();
                    if (ticketlineBindingSource.Count <= 0)
                    {
                        TotalAmountTextBox.Text = DisplayAmountAsText(0);
                        CashAmountTextBox.Text = DisplayAmountAsText(0);
                        ChangeAmountTextBox.Text = DisplayAmountAsText(0);
                    }
                    ticketlineBindingSource.ResetBindings(false);
                }
            }
            ticketlineBindingSource.ResetCurrentItem();
        }

        private void AddQuantity()
        {

            var ticketline = ticketlineBindingSource.Current as TicketLine;
            if (ticketline != null)
            {
                if (ticketline.Quantity < 32767) //TODO: replace with stock count
                    ticketline.Quantity += 1;
            }
            ticketlineBindingSource.ResetCurrentItem();
        }
        private void MoveSelectionUp()
        {
            var ticketline = ticketlineBindingSource.Current as TicketLine;
            if (ticketline != null)
            {
                ticketlineBindingSource.MovePrevious();
            }
        }
        private void MoveSelectionDown()
        {
            var ticketline = ticketlineBindingSource.Current as TicketLine;
            if (ticketline != null)
            {
                ticketlineBindingSource.MoveNext();
            }

        }
        private void SetCustomer()
        {
            var customerDialog = new CustomerDialog();
            if (customerDialog.ShowDialog(this) == DialogResult.OK)
            {
                ticket.Customer = customerDialog.Customer;
                CustomerTextBox.Text = customerDialog.Customer.Name;
                CustomerCodeTextBox.Text = customerDialog.Customer.CustomerCode;
            }
        }

        #endregion

        #region Shortcut Keys:
        //--F4
        private void ItemButton_Click(object sender, EventArgs e)
        {
            ItemCommand();
        }
        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemCommand();
        }

        //--F6
        private void CustomerButton_Click(object sender, EventArgs e)
        {
            SetCustomer();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCustomer();
        }

        //--F9
        private void MenuButton_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }
        private void ShowMenu()
        {
            var menuForm = new MenuDialog();
            menuForm.ShowDialog(this);
        }


        //--F10
        private void VoidButton_Click(object sender, EventArgs e)
        {
            ConfirmNewTransactionCreation();
        }
        private void voidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmNewTransactionCreation();
        }
        private void ConfirmNewTransactionCreation()
        {
            var result = MessageBox.Show(@"Are you sure you want to create a new transaction?",
                 @"Confirm Creating New Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                CreateNewTransaction();
            }
        }

        //--F12
        private void PayButton_Click(object sender, EventArgs e)
        {
            PayTransaction();
        }
        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayTransaction();
        }

        //--Del


        #endregion

        #region Initialization:
        public SalesForm()
        {

            InitializeComponent();
        }
        
        private void SalesForm_Load(object sender, EventArgs e)
        {
            printFont = new Font("Arial", 11f);
            gray = Brushes.Gray;
            receiptFont = new Font("Arial", 7.5f);
            creditFont = new Font("Arial", 7.5f);
            context = new PosContext();
            
            InitAll();
            NewTicket();
            InitItemTenderGrid();
            //--set focus to barcode
            Activate();
            BarcodeInputTextBox.Select();

        }

        #endregion

        #region Default Operations:
        private void EnterBarcodeButton_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrEmpty(BarcodeInputTextBox.Text))BarcodeInputTextBox.Select();
            InputBarcodeItem();
        }

        private void SalesForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        #region Barcode Events:
        private void BarcodeInputTextBox_TextChanged(object sender, EventArgs e)
        {
            DetectMdasItems();
        }
        private void QuantityButton_Click(object sender, EventArgs e)
        {
            CheckQuantity();
        }
        private void BarcodeInputTextBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = EnterBarcodeButton;
        }
        private void MultiplierTextBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = QuantityButton;
        }
        private void MultiplierTextBox_Leave(object sender, EventArgs e)
        {
            AcceptButton = EnterBarcodeButton;
        }
        private void PlusMinus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                AddQuantity();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                DeductQuantity();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveSelectionUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveSelectionDown();
            }

            CheckTotal();
        }
        #endregion

        #region Other Events: //Cell Mouse Leave, Clicks
        private void ItemTenderGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(BarcodeInputTextBox.Text)) BarcodeInputTextBox.Select();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BarcodeInputTextBox.Clear();
            BarcodeInputTextBox.Select();
        }

        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BarcodeInputTextBox.Text) && ticketlineBindingSource.Count > 0)
            {
                BarcodeInputTextBox.Text = "*";
                DetectMdasItems();
            }
        }

        private void StocksButton_Click(object sender, EventArgs e)
        {

        }
        #endregion






    }
}
