package Test;

import java.net.*;
import java.io.*;
import java.util.*;
 
class  ChatServer
 
{
 
    int port = 6000;
    ServerSocket server = null;
    Socket child = null;
 
    HashMap<String, PrintWriter> hm;
 
    public ChatServer() {
 
        ChatSverThread sr;
        Thread t;
 
        try {
            server = new ServerSocket( port ); //서버소켓을 생성
             
            System.out.println( "**************************************" );
            System.out.println( "*              채팅 서버                *" );
            System.out.println( "**************************************" );
            System.out.println( "클라이언트의 접속을 기다립니다." );
 
            hm = new HashMap<String, PrintWriter>();
 
            while( true ) {
                child = server.accept(); //클라이언트의 소켓을 연결받습니다.
                if( child != null ) { //클라이언트 소켓과 연결시
                    sr = new ChatSverThread( child, hm ); //채팅 스레드를 생성합니다.
                    t = new Thread(sr); //채팅스레드를 시작합니다.
                    t.start();
                }
            }
        }
        catch ( Exception e )   {
            e.printStackTrace();
        }
    }
 
 
 
    public static void main(String[] args)
 
    {
        new ChatServer();
    }
 
}
