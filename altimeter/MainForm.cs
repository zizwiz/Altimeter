using System;
using System.Windows.Forms;
using System.Reflection;
using CenteredMessagebox;

namespace Altimeter
{	
	public partial class MainForm : Form
	{
		public MainForm()
		{			
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
		}
			
		void Btn_closeClick(object sender, EventArgs e)
		{
			Close();
		}
		
		/// <summary>
		/// Work out the pressure at Sea level (QNH) and Destination (Destination QFE)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Btn_calculateClick(object sender, EventArgs e)
		{	
			if (CheckDataCorrect())
			{
				lbl_to_pressure.Text = Math.Round((float.Parse(txtbx_present_pressure.Text) + ((float.Parse(txtbx_present_altitude.Text) - float.Parse(txtbx_to_altitude.Text))/30)),2).ToString();
				lbl_qnh_pressure.Text = Math.Round((float.Parse(txtbx_present_pressure.Text) + ((float.Parse(txtbx_present_altitude.Text))/30)),2).ToString();
			}
			else
			{
				MsgBox.Show("Check you have filled in all the information correctly","Missing Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}		
		}
		
		/// <summary>
		/// Check That there is data and if there is check that it is the correct type.
		/// </summary>
		/// <returns>Bool</returns>
		public bool CheckDataCorrect()
		{
			int parsedValue;
			bool result = false;
			
			if ((txtbx_present_pressure.Text!="")&&(txtbx_present_altitude.Text!="")&&(txtbx_to_altitude.Text!=""))
			{
				result = true;
			
				if (!int.TryParse(txtbx_present_pressure.Text, out parsedValue))
				{
                    MsgBox.Show("Present QFE pressure must contain only numbers", "Check Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
					result = false;
				}
				
				if (!int.TryParse(txtbx_present_altitude.Text, out parsedValue))
				{
					MsgBox.Show("Present QFE pressure must contain only numbers", "Check Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				   	result = false;
				}
				
				if (!int.TryParse(txtbx_to_altitude.Text, out parsedValue))
				{
                    MsgBox.Show("Destination QFE pressure must contain only numbers", "Check Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				   	result = false;
				}
			}
			return result;
		}		
	}
}
