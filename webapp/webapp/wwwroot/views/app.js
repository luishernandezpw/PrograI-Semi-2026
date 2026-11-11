var formActivo = "";
document.addEventListener("DOMContentLoaded", e => {
    mnxAcademica.addEventListener("click", event => {
        event.preventDefault();
        abrirVentana(event.target.dataset.form);
    });
});

function abrirVentana(form) {
    let $ventana = $(`#${form}`); //#alumno, #materia, #docente, etc.
    if ($ventana.find("form").length > 0) {
        $ventana.show();
    } else {
        let url = `/views/${form}.html`;
        fetch(url).then(resp => resp.text()).then(vista => {
            $ventana.html(vista).draggable();
            cerrarVentana();
        });
    }
}
function cerrarVentana(){
    $('.btn-close').click(e => {
        $(`#${e.target.dataset.form}`).hidden();
    });
}

async function obtenerAlumnos(buscar = '') {
    const respuesta = await fetch(`api/Alumnos/buscar?buscar?=${buscar}`, {
        method: "GET",
        header: { "Content-Type": "application/json" }
    }),
        alumnos = await respuesta.json();
    return alumnos;
}