"use strict";

function addToMessageBoard(message) {
    var node = document.createElement("p");
    var textnode = document.createTextNode(message);
    node.appendChild(textnode);
    document.querySelector("#messageBoard").appendChild(node);
}

$(document).ready(function () {

    $("#btnSubmitGames").on("click", function () {

        var chkMW3 = $("#checkModernWarfare3").prop("checked");
        var chkBO = $("#checkBlackOps").prop("checked");
        var chkMP = $("#checkMarioPaint").prop("checked");

        if (!chkMW3 && !chkBO && !chkMP) {
            addToMessageBoard("No games checked");
        }

        if (chkMW3) {
            addToMessageBoard("Modern Warfare!");
        }
        if (chkBO) {
            addToMessageBoard("Black Ops!");
        }
        if (chkMP) {
            addToMessageBoard("Mario Paint!");
        }

        if (chkMW3 && chkBO && chkMP) {
            addToMessageBoard("All games checked");
        }

    });

    $("#btnResetMessageBoard").on("click", function () {
        $("#messageBoard p").remove();
        $("#messageBoard").empty();
    });

});