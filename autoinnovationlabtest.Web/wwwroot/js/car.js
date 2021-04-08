var carTable = $('#CarsTable').DataTable({
    "ordering": false,
    "language": {
        "sProcessing": "Procesando...",
        "sLengthMenu": "Mostrar _MENU_ registros",
        "sZeroRecords": "No se encontraron registros",
        "sEmptyTable": "No se encontraron registros",
        "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
        "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
        "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
        "sInfoPostFix": "",
        "sSearch": "Buscar:",
        "sUrl": "",
        "sInfoThousands": ",",
        "sLoadingRecords": "Cargando...",
        "oPaginate": {
            "sFirst": "Primero",
            "sLast": "Último",
            "sNext": "Siguiente",
            "sPrevious": "Anterior"
        },
        "oAria": {
            "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
            "sSortDescending": ": Activar para ordenar la columna de manera descendente"
        }
    },
    "processing": true, // for show progress bar
    "serverSide": true, // for process server side
    "filter": true, // this is for disable filter (search box)
    "orderMulti": false, // for disable multiple column at once
    "responsive": true,
    "ajax": {
        "url": "/Cars/GetCars",
        "type": "POST",
        "datatype": "json"
    },
    "columnDefs": [{
        "targets": [0],
        "visible": false,
        "searchable": false
    }],
    "columns": [
        { "data": "id", "name": "id", "autoWidth": true },
        { "data": "model", "name": "model", "autoWidth": true },
        { "data": "year", "name": "year", "autoWidth": true },
        { "data": "brand", "name": "brand", "autoWidth": true }
    ]
});

$("#BrandId").on('change', function () {
    carTable.columns(3).search(this.options[this.selectedIndex].text).draw();
});