Imports System.Data
Imports System.Data.SqlClient

Public Class NewRoom
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim frm As New HotelManagementSystemInVB.ReusableCode

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm.OpenCon()
        frm.InsertSQL("insert into room(r_type,r_no,r_rate,no_person,no_bed)values('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "')")
        MsgBox("Record inserted successfully..")
        Hide()
        frm.CloseCon()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = "--Select Room--"
        ComboBox2.Text = "--Select Person--"
        ComboBox3.Text = "--Select Bed--"
    End Sub
End Class