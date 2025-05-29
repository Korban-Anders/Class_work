import java.io.*;
import java.net.*;
class TCPClient {
	public static void main(String[] argv) throws Exception
	{
		String sentence;
		String modifiedSentence;
		BufferedReader inFromUser = new BufferedReader (
			new InputStreamReader(System.in));
		Socket clientSocket = new Socket(argv[0], 6789);
		/// Use 127.0.0.1 as argv[0] in the command line to run on own ip
		DataOutputStream outToServer = new DataOutputStream (
			clientSocket.getOutputStream());
		BufferedReader inFromServer =
			new BufferedReader (new InputStreamReader(
				clientSocket.getInputStream()));
		while (true) 
		{
			System.out.print("Message: ");
			sentence = inFromUser.readLine();
			outToServer.writeBytes(sentence + '\n');
			modifiedSentence = inFromServer.readLine();
			System.out.println("FROM SERVER: " +
					modifiedSentence);
		}
		//clientSocket.close(); 
	}
}
