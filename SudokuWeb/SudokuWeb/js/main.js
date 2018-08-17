function MostrarVentana(idDiv)
{
    $('#' + idDiv).modal('toggle');
}

function OcultarVentana(idDiv)
{
    $('#' + idDiv).modal('hide');
}

function PareceRobot()
{
    return alert('Debe Activar la casilla no soy un robot');
}