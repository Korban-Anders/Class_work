import java.io.* ;
import java.net.* ;
import java.util.* ;

public final class WebServer
{
	public static void main(String argv[]) throws Exception
	{
		// Set the port number.
		int port = 6789;

		// Establish the listen socket.
		ServerSocket listeningSocket; 
	 	
		// Process HTTP service requests in an infinite loop.
		while (true) {
			// Listen for a TCP connection request.
			listeningSocket = new ServerSocket(port);
			
			// Construct an object to process the HTTP request message.
	      	HttpRequest request = new HttpRequest(listeningSocket.accept());
	      	// Create a new thread to process the request.
	      	Thread thread = new Thread(request);
	      	// Start the thread.
	      	thread.start();
	      	
	      	listeningSocket.close();
		}
		
	}
}

final class HttpRequest implements Runnable
{
	final static String CRLF = "\r\n";
	Socket socket;

	// Constructor
	public HttpRequest(Socket socket) throws Exception 
	{
		this.socket = socket;
	}

	// Implement the run() method of the Runnable interface.
	public void run()
	{
		try {
			processRequest();
		} catch (Exception e) {
			System.out.println(e);
		}
	}

	private void processRequest() throws Exception
	{
		// Get a reference to the socket's input and output streams.
		InputStream is = socket.getInputStream();
		DataOutputStream os = new DataOutputStream (socket.getOutputStream());
		// Set up input stream filters.
		BufferedReader br = new BufferedReader (new InputStreamReader(is));
		
		//Get the request line of HTTP Request Message
		String requestLine = br.readLine();
		
		// Display the request line
		System.out.println();
		System.out.println(requestLine);
		
		//Get and display the header lines
		String headerLine = null;
		while ((headerLine = br.readLine()).length() != 0) {
			System.out.println(headerLine);
		}
		
		//Extract the filename from the request line
		StringTokenizer tokens = new StringTokenizer(requestLine);
		tokens.nextToken(); // skip over the method, which should be "GET"
		String fileName = tokens.nextToken();
		
		//Prepend a "." so that file request is within the current directory
		fileName= ".." + fileName;
		
		//Open the requested file
		FileInputStream fis = null;
		boolean fileExists = true;
		try {
			fis = new FileInputStream(fileName);
		}catch(FileNotFoundException e) {
			fileExists = false;
		}
		
		//Construct the response message
		String statusLine = null;
		String contentTypeLine = null;
		String entityBody = null;
		if(fileExists) {
			statusLine = "HTTP/1.0 200 Ok";
			contentTypeLine = "Content-Type: " + contentType( fileName ) + CRLF;
		}else {
			statusLine = "HTTP/1.0 404 Not Found";
			contentTypeLine = "Content-Type: " + "text/html" + CRLF;
			entityBody = "<HTML>" +
						"<HEAD><TITLE>Not Found</TITLE></HEAD>" +
						"<BODY>Status for file not found</BODY></HTML>";
		}
		
		//send the status line
		os.writeBytes(statusLine);
		//send the content type line
		os.writeBytes(contentTypeLine);
		//send a blank line to indicate the end of the header lines
		os.writeBytes(CRLF);
		
		// send the entity body
		if(fileExists) {
			sendBytes(fis, os);
			fis.close();
		}else {
			os.writeBytes(entityBody);
		}
		
		
		// Close Streams and Socket
		os.close();
		br.close();
		socket.close();
	}
	
	private static void sendBytes(FileInputStream fis, OutputStream os) throws Exception{
		// Construct a 1K buffer to hold bytes on their way to the socket.
		byte[] buffer = new byte[1024];
		int bytes = 0;
		
		//Copy requested file into the socket's output stream.
		while((bytes = fis.read(buffer)) != -1) {
			os.write(buffer, 0, bytes);
		}
	}
	
	private static String contentType(String fileName) {
		//returns sting based on what type of file it is
		if(fileName.endsWith(".htm") || fileName.endsWith(".html")) {
			return "text/html";
		}
		if(fileName.endsWith(".jpg") || fileName.endsWith(".jpeg")) {
			return "image/jpg";
		}
		if(fileName.endsWith(".gif")) {
			return "image/gif";
		}
		if(fileName.endsWith(".png")) {
			return "image/png";
		}
		//default if the file time is not listed here
		return "application/octet-stream";
	}
}