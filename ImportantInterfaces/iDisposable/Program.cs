using iDisposable;

using SqlUtility sqlUtility = new SqlUtility("connection_string");
sqlUtility.executeSql("insert to student");
sqlUtility.exicuteSqlQuery("select * from student");

