$.connection.hub.start()
    .done(function () {
        console.log("IT WORKED!")
        //$.connection.myHub.server.sendMessage("Connected!");
    })
    .fail(function () { alert("ERROR!") });

$.connection.myHub.client.sendMessage = function (addr, msg) {
    //alert(msg)
    switch (addr) {
        case 164:
            $("#lbl164").text(addr);
            $("#txt164").text(msg);
            break;
        case 166:
            $("#lbl166").text(addr);
            $("#txt166").text(msg);
            break;
        case 40003:
            $("#lbl40003").text(addr);
            $("#txt40003").text(msg);
            break;
        case 40004:
            $("#lbl40004").text(addr);
            $("#txt40004").text(msg);
            break;
        case 40005:
            $("#lbl40005").text(addr);
            $("#txt40005").text(msg);
            break;
    }
}