function MostrarVentana(idDiv)
{
    var ventana = document.getElementById(idDiv);
    ventana.style.display = 'block';
}

function OcultarVentana(idDiv)
{
    var ventana = document.getElementById(idDiv);
    ventana.style.display = 'none';
}

function PareceRobot()
{
    return alert('Debe Activar la casilla no soy un robot');
}