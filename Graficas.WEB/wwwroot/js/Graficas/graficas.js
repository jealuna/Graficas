    fetch('/GetAnalitica', {
        method: 'get'
    })
        .then(function (response) {
            return response.json();
        })
        .then(function (Datos) {
            creaGraficas(Datos);
        })
        .catch(function (err) {
            // Error :(
        });

    function creaGraficas(Datos) {
        Datos.forEach(function (obj, index) {
            var colors = ['red', 'green', 'blue', 'yellow', 'black', 'red'];
            $("#ContenedorGraficas").append("<div class='col-md-3'><div id='chart" + index + "'></div></div>");
            var columns = [
                [obj.etiquetaIzquierda + ' ', obj.cantidadIzquierda],
                [obj.etiquetaDerecha + ' ', obj.cantidadDerecha],
            ];
            var total = columns.reduce(function (sum, item) {
                return sum + item[1]
            }, 0);

            columns = columns.map(function (item) {
                return [
                    item[0] + ' '+ d3.format('.1%')(item[1] / total) + ' ' + item[1].toLocaleString('en'),
                    item[1]
                ]
            });
            var chart = c3.generate({
                data: {
                    columns: columns,
                    type: 'donut',
                },
                donut: {
                    expand: false,
                    title: obj.tipoGrafica + ' ' + (obj.cantidadIzquierda + obj.cantidadDerecha).toLocaleString('en'),
                },
                bindto: '#chart' + index
            });
        });
    }