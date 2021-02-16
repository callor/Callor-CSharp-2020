using MySql.Data.MySqlClient;
using System;



namespace SqlServerColumnstoreSample
{
    class MySqlDataClass
    { 
  
        public static String url = "SERVER=192.168.0.220; " +
            "USER=callor; " +
            "DATABASE=mybbs;" +
            "PORT=3306; " +
            "PASSWORD=!Korea8085; " +
            "SSLMODE=NONE";

        // DB접속 URL 설정 - SERVER : DB주소, USER : ID명, DATABASE : DB명, PORT : TCP 포트번호
        // PASSWORD : 비밀번호, SSLMODE : NONE (SSL 사용안함)
        private MySqlConnection mConnection; // DB접속
        private MySqlCommand mCommand; // 쿼리문
        private MySqlDataReader mDataReader; // 실행문

        public void SelectAll()
        {
            mConnection = new MySqlConnection(url); // DB접속
            mCommand = new MySqlCommand(); // 쿼리문 생성
            mCommand.Connection = mConnection; // DB에 연결
            mCommand.CommandText = "SELECT * FROM tbl_bbs"; // 쿼리문 작성
            mConnection.Open(); // DB 오픈
            mDataReader = mCommand.ExecuteReader(); // 쿼리문 실행
            while (mDataReader.Read()) // 전부 다 읽어 옴
            {

                // 여기서 부터 원하는 데이터를 받아와서 처리
                string strSubject = mDataReader["b_subject"].ToString();
                string strTime = mDataReader["b_time"].ToString();
                
                Console.WriteLine(strSubject);
            }
            mConnection.Close(); // 사용 후 객체 닫기
        }
    }
}



