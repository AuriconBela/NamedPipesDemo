using NamesPipesDemo.Pipes;
using System.Diagnostics;

namespace NamesPipesDemo
{
    public partial class Form1 : Form
    {
        public delegate void NewMessageDelegate(string NewMessage);
        private readonly PipeServer _pipeServer;

        private readonly int _id;

        private readonly List<Tuple<string, string>> _messages = new();
        private readonly BindingSource _source;
        public Form1()
        {
            InitializeComponent();
            _id = new Random().Next(100);

            lbId.Text = $"Id: {_id}";

            dgMessages.AutoGenerateColumns = false;
            dgMessages.DefaultCellStyle.SelectionBackColor = SystemColors.Window;
            dgMessages.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;

            _source = new BindingSource()
            {
                DataSource = _messages
            };

            dgMessages.DataSource = _source;

            _pipeServer = new PipeServer();
            _pipeServer.PipeMessage += new DelegateMessage(PipesMessageHandler);
        }


        private void PipesMessageHandler(string message)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new NewMessageDelegate(PipesMessageHandler), message);
                }
                else
                {
                    _messages.Add(new(string.Empty, message));
                    _source.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _pipeServer.Listen($"TestPipe_{_id}");
                Text = "Listening - OK";
                btnSend.Enabled = true;
                dgMessages.Enabled = true;

                return;
            }
            catch (Exception)
            {
                Text = "Error Listening";
            }
        }

        private void SendMessage()
        {
            if (string.IsNullOrEmpty(tbMessage.Text))
            {
                MessageBox.Show("Plese enter something", "Error");
                return;
            }

            if (string.IsNullOrEmpty(tbId.Text.Trim()) || (!int.TryParse(tbId.Text.Trim(), out var id)))
            {
                MessageBox.Show("Unable to parse id", "Error");
                return;
            }
            var _pipeClient = new PipeClient();
            _pipeClient.Send(tbMessage.Text.Trim(), $"TestPipe_{id}", 1000);

            _messages.Add(new(tbMessage.Text.Trim(), string.Empty));
            _source.ResetBindings(false);

            tbMessage.Text = string.Empty;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }
    }
}