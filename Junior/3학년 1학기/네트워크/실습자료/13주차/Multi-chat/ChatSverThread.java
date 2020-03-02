package Test;

import java.net.*;

import java.io.*;
 
import java.util.*;
 
 
 
public class ChatSverThread implements Runnable
 
{
    Socket child;
    BufferedReader ois;
    PrintWriter oos;
 
    String user_id;
    HashMap<String, PrintWriter> hm;
    InetAddress ip;
    String msg;
 
    public ChatSverThread(Socket s, HashMap<String, PrintWriter> h ) {
        child = s;
        hm = h;
 
        try {
            ois = new BufferedReader( new InputStreamReader( child.getInputStream() ) );
            oos = new PrintWriter( child.getOutputStream() );
 
            user_id = ois.readLine();
            ip = child.getInetAddress();
            System.out.println( ip + "로부터 " + user_id + "님이 접속하였습니다." );
            broadcast(user_id + "님이 접속하셨습니다.");
 
            synchronized( hm ) {   
                hm.put( user_id, oos );
            }
        }
 
        catch (Exception e ) {
            e.printStackTrace();
        }
 
    }
 
    public void run() {
        String receiveData;
 
        try
        {
            while( (receiveData = ois.readLine()) != null ) {
 
                if( receiveData.equals( "/quit" ) ) {
                    synchronized( hm ) {
                        hm.remove( user_id );
                    }
         
                    break;
                }
 
                else if( receiveData.indexOf( "/to" ) >= 0 ) {
                    sendMsg( receiveData );
                }
                
                else if ( receiveData.indexOf( "/userList") >= 0 ) {
                	userList(receiveData);
                }
                
                else if ( receiveData.indexOf( "/myName") >= 0 ) {
                	userList(receiveData);
                }
 
                else {
                    System.out.println(user_id + " >> " + receiveData );
                    oos.println("나 >>" + receiveData);
                    oos.flush();
                    broadcast( user_id + " >> " + receiveData );
                }
 
            }
 
        }
 
        catch (Exception e ) {
            e.printStackTrace();
        }
 
        finally {
            synchronized( hm ) {
                hm.remove( user_id );
            }
 
            broadcast( user_id + "님이 퇴장했습니다." );
            System.out.println( user_id + "님이 퇴장했습니다." );
 
            try
            {
                if( child != null ) {
                    ois.close();
                    oos.close();
                    child.close();
                }
            }
 
            catch ( Exception e) {}
        }
    }
 
 
 
    public void broadcast(String message){
        synchronized( hm ) {
            try{               
                Iterator<String> keys = hm.keySet().iterator();
                while ( keys.hasNext() ) {
                    String key = keys.next();
                    if(!key.equals(user_id)) {                 	
	                    PrintWriter temp_oss = hm.get(key);
	                    temp_oss.println( message );
	                    temp_oss.flush();
                    }
                }   
            }catch(Exception e){ }
        }
 
    }
 
    public void sendMsg(String message){
        int senderID_head = message.indexOf(" ") + 1;
        int senderID_tail  = message.indexOf(" ", senderID_head);
    }
    
    public void userList(String message) {
        try{
        }catch(Exception e){}
    }
    
    public void myName(String message) {
        try{
        }catch(Exception e){}
    }
    
    
 
}

