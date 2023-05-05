namespace FORM6
{
	public partial class Six : Form
	{
		public Six()
		{
			InitializeComponent();

			new Thread(UseUpdateMessage).Start();
		}

		private void img_btn_start_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Start", "clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void img_btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void UseUpdateMessage()
		{
			Thread.Sleep(5000);
			UpdateMessage($"START{Environment.NewLine}OR{Environment.NewLine}CLOSE");
		}

		private void UpdateMessage(string message)
		{
			Action action = () => lbl_title.Text = message;
			this.Invoke(action);
		}
	}
}