using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Func<string, string> func;
        SynchronizationContext sync;

        public string ToUpper (string text)
        {
            Thread.Sleep(3000);
            return text.ToUpper();
        }

        public void Callback(IAsyncResult asyncResult)
        {
            AsyncResult ar = asyncResult as AsyncResult;
            Func<string, string> caller = (Func<string, string>)ar.AsyncDelegate;
            string result = caller.EndInvoke(asyncResult);

            sync.Post(delegate { richTextBox1.Text = result; }, null);
        }

        private void IsCompleteButton_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            func = new Func<string, string>(ToUpper);
            IAsyncResult asyncResult = func.BeginInvoke(text, null, null);
            while (!asyncResult.IsCompleted)
            {
                Thread.Sleep(300);
            }
            MessageBox.Show("IsCompleted");
            richTextBox1.Text = func.EndInvoke(asyncResult).ToString();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            func = new Func<string, string>(ToUpper);
            IAsyncResult asyncResult = func.BeginInvoke(text, null, null);
                       
            richTextBox1.Text = func.EndInvoke(asyncResult).ToString();
            MessageBox.Show("EndInvoke");
        }

        private void CallbacButton_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            func = new Func<string, string>(ToUpper);
            func.BeginInvoke(text, Callback, null);

            sync = SynchronizationContext.Current;
            IAsyncResult asyncResult = func.BeginInvoke(text, Callback, null);
            MessageBox.Show("Callback");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
