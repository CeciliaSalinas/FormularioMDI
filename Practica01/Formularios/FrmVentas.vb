Public Class FrmVentas
    Public Shared primerInstancia As FrmVentas
    Public Function getInstancia() As FrmVentas

        If primerInstancia Is Nothing Then
            primerInstancia = New FrmVentas
            Return New FrmVentas
        Else
            Return primerInstancia
        End If

    End Function

    Public Sub ingresarDatos(productos As String)
        TxtProductos.Text = productos
    End Sub
    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'este botón busca del formulario la listaDeproductos para seleccionar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listaP As New FrmListaProductos
        'Cuadro de dialogo modal: Los cuadros de diálogo modales requieren que los usuarios
        'se completen y cierren antes de continuar con la ventana del propietario.
        'Estos cuadros de diálogo se usan mejor para tareas críticas o poco frecuentes
        'que requieren finalización antes de continuar.
        listaP.ShowDialog()

    End Sub

    Private Sub FrmVentas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        primerInstancia = Nothing
    End Sub
End Class