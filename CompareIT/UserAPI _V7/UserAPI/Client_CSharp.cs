using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UserAPI.Model;
//using.java.io
//
namespace UserAPI
{
    public class Client_CSharp
    {
        private Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private string json;
        private byte[] toSendBytes;
        private byte[] toSendLenBytes;
        private int toSendLen;
        private IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("192.168.1.6"), 6789);
          public Client_CSharp()
        {
           clientSocket.Connect(serverAddress);
        }
          public void SendUser(User user)
        {
            json = System.Text.Json.JsonSerializer.Serialize(user);
            json += "1";
            toSendLen = System.Text.Encoding.ASCII.GetByteCount(json);
            toSendBytes = System.Text.Encoding.ASCII.GetBytes(json);
            toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
            ReceiveMessage();
        }
        public List<UserWish> SendLogin (Login login)
        {
            json = System.Text.Json.JsonSerializer.Serialize(login);
            json += "2";
            toSendLen = System.Text.Encoding.ASCII.GetByteCount(json);
            toSendBytes = System.Text.Encoding.ASCII.GetBytes(json);
            toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
            var boolean = ReciveVerification();
            if (boolean)
            {
                return ReceiveMessage();
            }
            else
                throw new Exception("false");
        }

      
        public void SendWish(UserWish userWish)
        {
            json = System.Text.Json.JsonSerializer.Serialize(userWish);
            json += "3";
            toSendLen = System.Text.Encoding.ASCII.GetByteCount(json);
            toSendBytes = System.Text.Encoding.ASCII.GetBytes(json);
            toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
            ReceiveMessage();
        }
        public void SendDelete(UserWish userWish)
        {
            json = System.Text.Json.JsonSerializer.Serialize(userWish);
            json += "4";
            toSendLen = System.Text.Encoding.ASCII.GetByteCount(json);
            toSendBytes = System.Text.Encoding.ASCII.GetBytes(json);
            toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
            ReceiveMessage();
        }

        public List<UserWish> ReceiveMessage() { 
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            String rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);
            Console.WriteLine("Client received: " + rcv);
            if (rcv.Equals("true"))
            {
                clientSocket.Close();
                return new List<UserWish>();
            }
            else
            {
                var wishlist = JsonConvert.DeserializeObject<List<UserWish>>(rcv);
                clientSocket.Close();
                return wishlist;
            }
        }

        public  bool ReciveVerification()
        {
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            String rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);

            bool result =bool.Parse(rcv);
            Console.WriteLine("Result>>>>"+result);
            return result;
        }
    }
}