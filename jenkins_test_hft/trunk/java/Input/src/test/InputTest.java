package test;

import static org.junit.Assert.*;
import input.Input;

import java.io.File;
import java.io.IOException;

import org.junit.AfterClass;
import org.junit.Test;


public class InputTest{

	static String content = "9.09969710;48.70126700;16.674;16.810;-13.785;-13.859;89.676;90.238;920.891;930.010;23000";
	

	
	@Test
	public void fileExists(){
		assertTrue(new File("../Output.txt").exists());
	}
	
	@Test
	public void isContentCorrect() throws IOException{
		Input i = new Input();		assertEquals(i.readString(), content);
		
		
	}
	
    @AfterClass 
    public static void cleanUp() {
        new File("../Output.txt").delete();
    }}

