using System; //ckecking out book to uses what is inside these "books"
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Xplane_app //organied data, like areas codes
{
	class Program 
	{
		//sim/flight_controls/brakes_regular
        public static byte[] Combine(byte[] first, byte[] second)//saying if you give me two gyte i will combine them and give a bigger one, two thing that whated to be joined
		{
			byte[] ret = new byte[first.Length + second.Length];
			Buffer.BlockCopy(first, 0, ret, 0, first.Length);
			Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
			return ret;
		}



		static void Main(string[] args)//each program has an enternce and only one main enternce
		{
			byte[] data = Encoding.ASCII.GetBytes("C" + "M" + "N" + "D" + "\0");//bacially saying take hello world and converted it to ones and zeros
			//string cmndPath = "sim/flight_controls/brakes_regular";
			string cmndPath = "sim/engines/throttle_up";
			byte[] cmndData = Encoding.ASCII.GetBytes(cmndPath + "\0");
			byte[] combineData = Combine(data, cmndData);

			string ipAddress = "127.0.0.1";//local host in a # verison
			int sendPort = 49000;//like house numbers on a street
			try//this has to live in a try and catch block
			{
				using (var client = new UdpClient())//"book" checked out is being used
				{
					IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ipAddress), sendPort);//names of book that are being used, that other people ave written that i use and book need info like ipAddress and port
					client.Connect(ep);//like a call that sends data over, also can recive
					client.Send(combineData, combineData.Length);
					Console.WriteLine("data was sent", combineData.Length);
					Console.ReadLine();
				}
			}
			catch (Exception ex)//go here to print out what happen, only if bad thing happen it will go down here
			{
				Console.WriteLine(ex.ToString());//printing out to the console
			}
		}
	}
}
