Imports System.Data
Imports System.Data.SqlClient

Public Class Employee
    Dim da As New SqlDataAdapter
    Dim frm As New HotelManagementSystemInVB.ReusableCode
    Dim ds As New DataSet

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm.OpenCon()
        frm.InsertSQL("insert into employee(name,mobile,gender,addr,role,join_date,shift,salary)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Value.Date & "','" & ComboBox3.Text & "','" & TextBox4.Text & "')")
        MsgBox("Record inserted successfully..")
        Hide()
        frm.CloseCon()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select Role--"
        ComboBox3.Text = "--Select Shift--"
    End Sub
End Class