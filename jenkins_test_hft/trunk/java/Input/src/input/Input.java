package input;


import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class Input {
	
	public  String readString() throws IOException{
		BufferedReader br = new BufferedReader(new FileReader("../Output.txt"));
		String content = "";
	    try {
	        StringBuilder sb = new StringBuilder();
	        String line = br.readLine();

	        while (line != null) {
	            sb.append(line);
	            line = br.readLine();
	        }
	        content = sb.toString();


	    } finally {
	        try {
				br.close();
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
	    }
	    return content;
	}

}
