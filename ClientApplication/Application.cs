using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
/*
 * 
 * author: Marina Sichova
 * student Id: P272494
 * created: 03/04/2023
 * last updated: 30/04/2023
 * 
 * Client Side Application
 * UI
 * 
 * Reference: used in code formula from this forum:https://stackoverflow.com/questions/12127577/convert-rgb-to-grayscale-b
 * to determine if the selected color is dark or light 
 */
namespace ClientApplication
{
    public partial class Application : Form
    {
        //connection to the server application
        NetNamedPipeBinding binding = null;
        EndpointAddress endpoint = null;
        public void ConnectToServer()
        {
            try
            {
                binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
                endpoint = new EndpointAddress("net.pipe://localhost/astroMath");
            }
            catch (EndpointNotFoundException error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
            }
            catch (FaultException error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
            }
            catch (PipeException error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
            }
            catch (IOException error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
            }
        }
        //Method returns string for Header for Error Message
        //Dippends on what language user is using in current application
        public string ErrorMessageHeading()
        {
            if (!btnLngEnglish.Enabled)
                return "Server connection problem";
            if (!btnLngFrench.Enabled)
                return "Problème de connexion au serveur";
            if (!brnLngGerman.Enabled)
                return "Serververbindungsproblem";

            return "Server connection problem";
        }

        public Application()
        {
            ConnectToServer();
            InitializeComponent();
        }

        //Methods that calls method to change language of form in application
        //setting the pressed button to not active
        private void btnLngFrench_Click(object sender, EventArgs e)
        {
            reloadForm("fr", sender, e);
            btnLngFrench.Enabled = false;
            btnLngEnglish.Enabled = true;
            brnLngGerman.Enabled = true;
        }
        private void btnLngEnglish_Click(object sender, EventArgs e)
        {
            reloadForm("en-Gb", sender, e);
            btnLngFrench.Enabled = true;
            btnLngEnglish.Enabled = false;
            brnLngGerman.Enabled = true;
        }
        private void brnLngGerman_Click(object sender, EventArgs e)
        {
            reloadForm("de", sender, e);
            btnLngFrench.Enabled = true;
            btnLngEnglish.Enabled = true;
            brnLngGerman.Enabled = false;
        }

        //changing UI Culture,
        //and reload form with translated components to user choosed of language
        private void reloadForm(string language, object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            //saving data into list from dataGridDisplay
            List<string> data = new List<string>();
            foreach(DataGridViewRow row in dataGridDisplay.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    data.Add(cell.FormattedValue.ToString());
                }
            }

            Color backColor = this.BackColor;
            Color textColor = this.ForeColor;

            //Reloading form with translated components
            Controls.Clear();
            InitializeComponent();
            Application_Load(sender, e);
            formThems(backColor, textColor);

            //adding data into DataGridView from List
            for (int row = 0, dataI = 0; dataI < data.Count; row++)
            {
                dataGridDisplay.Rows.Add();
                for(int cell = 0; cell < dataGridDisplay.ColumnCount; cell++)
                {
                    dataGridDisplay.Rows[row].Cells[cell].Value = data[dataI++];
                }
            }

        }

        private void rdoNightMode_CheckedChanged(object sender, EventArgs e)
        {
            //depending if radio button for night mode checked or not
            Color firstColor = (rdoNightMode.Checked) ? Color.Black : Color.White;
            Color secondColor = (rdoNightMode.Checked) ? Color.White : Color.Black;
            formThems(firstColor, secondColor);
        }

        private void rdoNightMode_Click(object sender, EventArgs e)
        {
            rdoNightMode.Checked = (rdoNightMode.Checked) ? false : true;
        }

        //finds out if color of user choice is light or dark
        //if light then sets the text components in form to black
        //if dark then sets the text components to white
        //used formula from this forum: https://stackoverflow.com/questions/12127577/convert-rgb-to-grayscale-b
        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                rdoNightMode.Checked = false;

                Color color = ((0.299 * clrDialog.Color.R + 0.587 * clrDialog.Color.G + 0.114 * clrDialog.Color.B) < 127.5) ? Color.White : Color.Black;
                formThems(clrDialog.Color, color);

            }
        }

        //changes color of all form components, depends on their type
        private void formThems(Color backGroundColor, Color textColor)
        {
            this.BackColor = backGroundColor;
            this.ForeColor = textColor;

            //Components of DataGreedView
            dataGridDisplay.EnableHeadersVisualStyles = false;
            dataGridDisplay.BackgroundColor = backGroundColor;
            dataGridDisplay.GridColor = textColor;
            dataGridDisplay.RowsDefaultCellStyle.BackColor = backGroundColor;
            dataGridDisplay.RowsDefaultCellStyle.ForeColor = textColor;
            dataGridDisplay.RowHeadersDefaultCellStyle.BackColor = backGroundColor;
            dataGridDisplay.RowHeadersDefaultCellStyle.ForeColor = textColor;

            //combo box
            cmbEHpows.BackColor = backGroundColor;
            cmbEHpows.ForeColor = textColor;

            foreach (Control controls in this.Controls)
            {
                controls.ForeColor = textColor;

                if (controls is Button)
                {
                    controls.BackColor = backGroundColor;
                }

                if (controls is GroupBox)
                {
                    controls.ForeColor = textColor;

                    foreach (Control control in controls.Controls)
                    {
                        if (control is TextBox)
                        {
                            control.BackColor = backGroundColor;
                            control.ForeColor = textColor;
                        }
                    }
                }
            }
        }

        //lets user in text boxes to enter only numbers, and backspace
        //checks dot not to by first symbole in input data
        //checks symbole minus should be only one and as first element
        //allows to enter only one dot and minus symbol or none
        private void Check_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) && (!(e.KeyChar).Equals(((char)Keys.Back))) &&
                (!e.KeyChar.Equals('.')) &&
                (!e.KeyChar.Equals('-'))) ? true : false;

            //checks for quantity of dots and minus and position of this symbols in input data  
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals('e') || e.KeyChar.Equals('-'))
            {
                if (sender is TextBox)
                {
                    TextBox text = sender as TextBox;
                    if(e.KeyChar.Equals('.') || e.KeyChar.Equals('e'))
                    {
                        //dot should not be first symbol in input data
                        e.Handled = (text.Text.ToString().Count(symbol => symbol == '.') > 0) ||
                        (text.Text.Length == 0)
                        ? true : false;
                    }
                    else
                    {
                        //minus could be only as first symbol in input data
                        e.Handled = (text.Text.Length == 0) ? false : true;
                    }
                        
                }
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            dataGridDisplay.Rows.Add();
            int count = dataGridDisplay.Rows.Count - 1;
            IAstrocontracts popeProxy;
            try
            {
                popeProxy = ChannelFactory<IAstrocontracts>.CreateChannel(binding, endpoint);

                if (txtSVObserved.Text.Length > 0 && txtSVRest.Text.Length > 0)
                {
                    double starVelocity = popeProxy.StarVelocity(Double.Parse(txtSVObserved.Text), Double.Parse(txtSVRest.Text));
                    dataGridDisplay.Rows[count].Cells[0].Value = starVelocity + " m/s";
                }
                if (txtSDParallaxAngle.Text.Length > 0)
                {
                    double starDistance = popeProxy.StarDistance(Double.Parse(txtSDParallaxAngle.Text));
                    dataGridDisplay.Rows[count].Cells[1].Value = starDistance + " parsec";
                }
                if (txtTKDegrees.Text.Length > 0)
                {
                    double tempKelvin = popeProxy.TempretureInKelvin(Double.Parse(txtTKDegrees.Text));
                    dataGridDisplay.Rows[count].Cells[2].Value = tempKelvin + " K";
                }
                if (txtKilometers.Text.Length > 0)
                {
                    double eventHorizon = popeProxy.EventHorizon(Double.Parse(txtKilometers.Text), Int32.Parse(cmbEHpows.Text));
                    dataGridDisplay.Rows[count].Cells[3].Value = eventHorizon + " *10^10 m";
                }
                ClearTextFields();
            }
            catch (EndpointNotFoundException  error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
                this.Close();
            }
            catch (FaultException error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
                this.Close();
            }
            catch (PipeException error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
                this.Close();
            }
            catch (ChannelTerminatedException error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
                this.Close();
            }
            catch (ServerTooBusyException  error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
                this.Close();
            }
            catch (TimeoutException error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
                this.Close();
            }
            catch (CommunicationException error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), ErrorMessageHeading());
                this.Close();
            }
        }
        
        //to clear text fields and reset to default
        private void ClearTextFields()
        {
            foreach (Control controlGroup in this.Controls)
            {
                if (controlGroup is GroupBox)
                {
                    foreach (Control control in controlGroup.Controls)
                    {
                        if (control is TextBox)
                        {
                            control.Text = string.Empty;
                        }
                    }
                }
            }
            cmbEHpows.SelectedIndex = 26;
        }
        //fills combo box
        //chooses theme by device time
        private void Application_Load(object sender, EventArgs e)
        {
            for (int i = 10; i < 41; i++)
            {
                cmbEHpows.Items.Add(i);
            }
            cmbEHpows.SelectedIndex = 26;
            rdoNightMode.Checked = (((DateTime.Now.Hour > -1) && (DateTime.Now.Hour < 7)) || (DateTime.Now.Hour > 18)) ? false : true;
            rdoNightMode_CheckedChanged(sender, e);
        }
        //exits application with combination key: X + Shift + Control
        private void Application_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString().Equals("X, Shift, Control"))
            {
                this.Close();
            }
        }

        //Entered value in txtTKDegrees must be greater than -273.
        private void txtTKDegrees_Leave(object sender, EventArgs e)
        {
                if(Double.TryParse(txtTKDegrees.Text.ToString(), out double value))
                {
                    if(value < -272.9)
                    {
                        txtTKDegrees.Clear();
                        txtTKDegrees.Text = "-272.9";
                        MessageBox.Show(lblTKTempreture.Text + " <= -273", grbTempretureInKelvin.Text);
                    }
                }
        }
    }
}
