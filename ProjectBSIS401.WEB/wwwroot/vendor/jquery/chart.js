 // Load the Visualization API and the piechart package
google.charts.load('current', { 'packages': ['corechart'] });

// Set a callback to run when the Google Visualization API is loaded.
google.charts.setOnLoadCallback(drawChart);

var _jsonDarta
function drawChart() {
    $.get("/shop/get-comments", function (data, status) {
        var jsonData = data;
     
    });
       
    // Create our data table out of JSON data loaded from server.
    var data = new google.visualization.DataTable(jsonData);

    // Instantiate and draw our chart, passing in some options.
    var chart = new google.visualization.PieChart(document.getElementById('piechart'));
    chart.draw(data, { width: 400, height: 240 });
}





google.charts.load('current', { 'packages': ['timeline'] });
google.charts.setOnLoadCallback(drawChart);
function drawChart() {
    var container = document.getElementById('timeline');
    var chart = new google.visualization.Timeline(container);
    var dataTable = new google.visualization.DataTable();

    dataTable.addColumn({ type: 'string', id: 'President' });
    dataTable.addColumn({ type: 'date', id: 'Start' });
    dataTable.addColumn({ type: 'date', id: 'End' });
    dataTable.addRows([
        ['Washington', new Date(1789, 3, 30), new Date(1797, 2, 4)],
        ['Adams', new Date(1797, 2, 4), new Date(1801, 2, 4)],
        ['Jefferson', new Date(1801, 2, 4), new Date(1809, 2, 4)]]);

    chart.draw(dataTable);
}