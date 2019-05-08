Imports System.Data
Imports System.Data.SqlClient

Public Class ReusableCode
    Dim con As New SqlConnection
    Dim com As SqlCommand

    Public Sub OpenCon() 'Open connection to database'
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Allump\UMP sem6\evolution & maintenance\assignemtn\HotelManagementSystemInVB\HotelManagementSystemInVB\Database1.mdf;Integrated Security=True")
        con.Open()
    End Sub

    Public Sub InsertSQL(ByVal cmd As String) 'store data'
        com = New SqlCommand(cmd, con)
        com.ExecuteNonQuery()
    End Sub

    Public Function SelectSQL(ByVal cmd As String) As SqlDataReader 'Read data'
        com = New SqlCommand(cmd, con)
        Return com.ExecuteReader()
    End Function

    Public Sub CloseCon() 'Close connection to database'
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Allump\UMP sem6\evolution & maintenance\assignemtn\HotelManagementSystemInVB\HotelManagementSystemInVB\Database1.mdf;Integrated Security=True")
        con.Close()
    End Sub
End Class
