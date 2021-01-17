$(document).ready(function() {

    let transaccionesTotales = 0;
    let beneficio = 0;

    $.ajax({
        url: 'https://localhost:44394/resumenventas',
        dataType: 'json',
        type: 'get',
        contentType: 'application/json',
        success: function(data) {
            //Por cada elemento dentro del array data, construye una fila (tr)
            //y añade celdas con los campos de cada elemento del array.

            console.log(data);

            $.each(data, function(i, item) {
                transaccionesTotales += item.transacciones;
                beneficio += item.beneficios;
                var $tr = $('<tr id="fila">').append(
                    $('<td>').text(item.user),
                    $('<td>').text(item.beneficios),
                    $('<td>').text(item.transacciones)
                ); //.appendTo('#records_table');

                $('#informacionVentas').append($tr);
            });

            $("#cantidad").val(transaccionesTotales);
            $("#beneficio").val(beneficio + " €");

            //////////////////////////////////////////////////////

            var svg = d3.select("svg"),
                margin = 200,
                width = svg.attr("width") - margin,
                height = svg.attr("height") - margin


            var xScale = d3.scaleBand().range([0, width]).padding(0.4),
                yScale = d3.scaleLinear().range([height, 0]);

            var g = svg.append("g")
                .attr("transform", "translate(" + 100 + "," + 100 + ")");


            xScale.domain(data.map(function(d) {
                return d.user;
            }));
            yScale.domain([0, d3.max(data, function(d) {
                return d.beneficios;
            })]);

            g.append("g")
                .attr("transform", "translate(0," + height + ")")
                .call(d3.axisBottom(xScale))
                .append("text")
                .attr("y", height - 250)
                .attr("x", width - 100)
                .attr("text-anchor", "end")
                .attr("stroke", "black")
                .text("Usuarios");

            g.append("g")
                .call(d3.axisLeft(yScale).tickFormat(function(d) {
                        return "$" + d;
                    })
                    .ticks(10))
                .append("text")
                .attr("transform", "rotate(-90)")
                .attr("y", 6)
                .attr("dy", "-7.1em")
                .attr("text-anchor", "end")
                .attr("stroke", "black")
                .text("Beneficios");

            g.selectAll(".bar")
                .data(data)
                .enter().append("rect")
                .attr("class", "bar")
                .attr("x", function(d) { return xScale(d.user); })
                .attr("y", function(d) { return yScale(d.beneficios); })
                .attr("width", xScale.bandwidth())
                .attr("height", function(d) {
                    return height - yScale(d.beneficios);
                });

        }
    });
});

$("#buscador").on("keyup", function() {
    var value = $(this).val().toLowerCase();
    $(".table #fila").filter(function() {
        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
    });
});