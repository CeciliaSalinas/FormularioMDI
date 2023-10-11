Public Class FrmListaProductos

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim formularioVentas As FrmVentas = FrmVentas.getInstancia
        Dim productos As String = ListBox1.SelectedItem.ToString
        'ListBox1.SelectedItem.ToString()
        'ToString devuelve el nombre de tipo completo de esta instancia
        formularioVentas.ingresarDatos(productos)
    End Sub

End Class
