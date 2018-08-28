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

function OpenProfileAdministrador1()
{
    window.location = 'ProfileAdministrador.aspx?div=CreateAdmin';  
}

function OpenProfileAdministrador2()
{
    window.location = 'ProfileAdministrador.aspx?div=OlvidoUsuario';
}

function OpenProfileAdministrador3()
{
    window.location = 'ProfileAdministrador.aspx?div=OlvidoPassword';
}

function CerrarPestana()
{
    window.open('', '_parent', ''); 
    window.close('Entry.aspx');
}

function MoverseA(idDelElemento)
{
    location.hash = "#" + idDelElemento;
}

