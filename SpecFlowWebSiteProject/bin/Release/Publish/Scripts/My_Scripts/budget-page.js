"use strict";

$(document).ready(function () {

    class BudgetCalculator {
        constructor(salary, traditional401k, taxRate) {
            this.salary = Number(salary);
            this.traditional401k = Number(traditional401k);
            this.taxRate = Number(taxRate);
        }

        salaryByYear() { return (this.salary).toFixed(2); }
        salaryByMonth() { return (this.salary / 12).toFixed(2); }
        salaryByBiWeek() { return (this.salary / 26).toFixed(2); }
        salaryByWeek() { return (this.salary / 52).toFixed(2) }
        salaryByDay() { return (this.salaryByWeek() / 5).toFixed(2); }

        traditional401kByYear() { return (this.traditional401k).toFixed(2); }
        traditional401kByMonth() { return (this.traditional401k / 12).toFixed(2); }
        traditional401kByBiWeek() { return (this.traditional401k / 26).toFixed(2); }
        traditional401kByWeek() { return (this.traditional401k / 52).toFixed(2); }
        traditional401kByDay() { return (this.traditional401kByWeek() / 5).toFixed(2); }

        taxesByYear() { return ((this.salaryByYear() - this.traditional401kByYear()) * (this.taxRate * 0.01)).toFixed(2); }
        taxesByMonth() { return (this.taxesByYear() / 12).toFixed(2); }
        taxesByBiWeek() { return (this.taxesByYear() / 26).toFixed(2); }
        taxesByWeek() { return (this.taxesByYear() / 52).toFixed(2); }
        taxesByDay() { return (this.taxesByWeek() / 5).toFixed(2); }

        cashByYear() { return (this.salaryByYear() - this.traditional401kByYear() - this.taxesByYear()).toFixed(2); }
        cashByMonth() { return (this.salaryByMonth() - this.traditional401kByMonth() - this.taxesByMonth()).toFixed(2); }
        cashByBiWeek() { return (this.salaryByBiWeek() - this.traditional401kByBiWeek() - this.taxesByBiWeek()).toFixed(2); }
        cashByWeek() { return (this.salaryByWeek() - this.traditional401kByWeek() - this.taxesByWeek()).toFixed(2); }
        cashByDay() { return (this.salaryByDay() - this.traditional401kByDay() - this.taxesByDay()).toFixed(2); }
    }

    /* Returns:
    True if all validations pass
    False if any validations fail
    */
    function refreshValidations() {
        $("#validationMessages p").remove();
        $("#validationMessages").empty();

        var validationsList = []

        if ($("#salary").val() == "") validationsList.push("Salary is required.");
        if ($("#salary").val() < 0) validationsList.push("Salary must be greater than or equal to zero.");
        if (!Number.isInteger(parseInt($("#salary").val()))) validationsList.push("Salary must be an integer.");

        if ($("#traditional401k").val() == "") validationsList.push("401k is required.")
        if (($("#traditional401k").val() < 0) || (($("#traditional401k").val() > 19000))) validationsList.push("401k must be between 0 and 19000.");
        if (!Number.isInteger(parseInt($("#traditional401k").val()))) validationsList.push("401k must be an integer.");

        if ($("#taxRate").val() == "") validationsList.push("Tax Rate is required.")
        if (($("#taxRate").val() < 0) || ($("#taxRate").val() > 100)) validationsList.push("Tax Rate must be between 0 and 100.");
        if (!Number.isInteger(parseInt($("#taxRate").val()))) validationsList.push("Tax Rate must be an integer.");

        validationsList.forEach(function (validation) {
            var node = document.createElement("p");
            var textNode = document.createTextNode(validation);
            node.appendChild(textNode);
            document.querySelector("#validationMessages").appendChild(node);
        });

        if (validationsList.length > 0) return false;
    }

    function calculateBudget() {
        var budgetCalculator = new BudgetCalculator(
            $("#salary").val(),
            $("#traditional401k").val(),
            $("#taxRate").val());

        $("#salaryByYear").text(budgetCalculator.salaryByYear());
        $("#salaryByMonth").text(budgetCalculator.salaryByMonth());
        $("#salaryByBiWeek").text(budgetCalculator.salaryByBiWeek());
        $("#salaryByWeek").text(budgetCalculator.salaryByWeek());
        //$("#salaryByDay").text = budgetCalculator.salaryByDay();

        $("#investByYear").text(budgetCalculator.traditional401kByYear());
        $("#investByMonth").text(budgetCalculator.traditional401kByMonth());
        $("#investByBiWeek").text(budgetCalculator.traditional401kByBiWeek());
        $("#investByWeek").text(budgetCalculator.traditional401kByWeek());
        //$("#investByDay").text = budgetCalculator.traditional401kByDay();

        $("#taxesByYear").text(budgetCalculator.taxesByYear());
        $("#taxesByMonth").text(budgetCalculator.taxesByMonth());
        $("#taxesByBiWeek").text(budgetCalculator.taxesByBiWeek());
        $("#taxesByWeek").text(budgetCalculator.taxesByWeek());
        //$("#taxesByDay").text = budgetCalculator.taxesByDay();

        $("#cashByYear").text(budgetCalculator.cashByYear());
        $("#cashByMonth").text(budgetCalculator.cashByMonth());
        $("#cashByBiWeek").text(budgetCalculator.cashByBiWeek());
        $("#cashByWeek").text(budgetCalculator.cashByWeek());
        //$("#cashByDay").text = budgetCalculator.cashByDay();
    }

    $("#calculateBudget").click(function () {
        if (!refreshValidations()) calculateBudget();
    });
});