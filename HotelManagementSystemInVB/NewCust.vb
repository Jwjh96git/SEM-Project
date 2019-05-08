Imports System.Data
Imports System.Data.SqlClient

Public Class NewCust
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim getcust As String
    Dim frm As New HotelManagementSystemInVB.ReusableCode

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm.OpenCon()
        frm.InsertSQL("insert into customer(name,mobile,nation,gender,city,state)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')")
        dr = frm.SelectSQL("select max(id) from customer")
        If dr.Read() Then
            MsgBox("Record inserted successfully..Your id is '" & dr.GetInt32(0) & "'")
            Hide()
        End If
        frm.CloseCon()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox2.Text = "--Select--"
    End Sub
End Class