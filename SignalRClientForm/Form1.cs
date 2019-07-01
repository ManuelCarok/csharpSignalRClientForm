using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SignalRClientForm
{
    public partial class Form1 : Form
    {
        HubConnection connection;
        IHubProxy chat;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void BtnOn_Click(object sender, EventArgs e)
        {
            connection.Start().ContinueWith(task => {
                if (task.IsFaulted)
                {
                    btnOn.Enabled = true;
                    btnOff.Enabled = false;
                    btnEnviar.Enabled = false;
                    lblEstado.Text = "Desconectado";
                    txtChat.AppendText(string.Format("Se produjo un error al abrir la conexión: {0}", task.Exception.GetBaseException(), "\n"));
                }
                else
                {
                    btnOn.Enabled = false;
                    btnOff.Enabled = true;
                    btnEnviar.Enabled = true;
                    lblEstado.Text = "Conectado";
                    chat.Invoke<string>("Connect", "Middleware").Wait();
                }
            }).Wait();
        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            btnOn.Enabled = true;
            btnOff.Enabled = false;
            btnEnviar.Enabled = false;
            lblEstado.Text = "Desconectado";
            connection.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new HubConnection("http://localhost:54052/");
            chat = connection.CreateHubProxy("chat");

            chat.On<string, string>("broadcastMessage", (username, message) => {
                txtChat.AppendText(string.Format("{0}: {1} \n", username, message));
            });

            chat.On<string, List<string>>("updateUsers", (userCount, userList) =>
            {
                txtUsers.Text = "";
                foreach (string client in userList)
                {
                    txtUsers.AppendText(client + "\n");
                }
            });

            connection.Start().ContinueWith(task => {
                if (task.IsFaulted)
                {
                    btnOn.Enabled = true;
                    btnOff.Enabled = false;
                    btnEnviar.Enabled = false;
                    lblEstado.Text = "Desconectado";
                    txtChat.AppendText(string.Format("Se produjo un error al abrir la conexión: {0}", task.Exception.GetBaseException(), "\n"));
                }
                else
                {
                    btnOn.Enabled = false;
                    btnOff.Enabled = true;
                    btnEnviar.Enabled = true;
                    lblEstado.Text = "Conectado";
                    chat.Invoke<string>("Connect", "Middleware").Wait();
                }

            }).Wait();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Stop();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            chat.Invoke<string>("Send", txtEnviar.Text).Wait();
        }
    }
}
