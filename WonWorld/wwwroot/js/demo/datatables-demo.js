// Call the dataTables jQuery plugin
$(document).ready(function() {
    $('#dataTable2').DataTable();
});
window.SetTable = (e) => {
    console.log(e,"����");
    $('#dataTable').DataTable();
};