Public Class FrmListaProductos

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        'le asigno lo que me devuelve el mètodo getInstancia
        'me devuelve un objeto de tipo FrmVentas
        Dim formularioVentas As FrmVentas = FrmVentas.getInstancia

        ' le asigno a productos el elemento que se selecciona del listBox
        Dim productos As String = ListBox1.SelectedItem.ToString

        'inserta la informacion del elemento selecionado del listbOX
        formularioVentas.ingresarDatos(productos)

        Me.Close()

    End Sub

End Class
