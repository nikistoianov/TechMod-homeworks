const Calculator = require('../models/Calculator');

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost: (req, res) => {
        let calculatorBoby = req.body;
        let calculatorParams = calculatorBoby['calculator'];
        let calculator = new Calculator();
        calculator.leftOperand = Number(calculatorParams.leftOperand);
        calculator.operator = calculatorParams.operator;
        calculator.rightOperand = Number(calculatorParams.rightOperand);

        let result = calculator.calculateResult();

        res.render('home/index', {'calculator': calculator, 'result': result});
    }
};