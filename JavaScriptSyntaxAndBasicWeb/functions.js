function MultiplyBy2 (arr) {
    let result = Number(arr[0]) * 2;
    return result;
}

function MultiplyTwoNumbers(arr) {
    let num1 = Number(arr[0]);
    let num2 = Number(arr[1]);
    let result = num1 * num2;
    return result;
}

function MultiplyOrDivide(arr) {
    let num1 = Number(arr[0]);
    let num2 = Number(arr[1]);
    if (num1 > num2) {
        return num1 / num2;
    } else {
        return num1 * num2;
    }
}

function ProductOf3Numbers(arr) {
    let num1 = Number(arr[0]);
    let num2 = Number(arr[1]);
    let num3 = Number(arr[2]);
    let isPositive = (num1 < 0) + (num2 < 0) + (num3 < 0);
    if (isPositive % 2 == 0) {
        return 'Positive';
    } else {
        return 'Negative';
    }
}

function PrintNumbers1ToN(num) {
    for (let i = 1; i <= num; i++) {
        console.log(i);
    }
}

function PrintNumbersNTo1(num) {
    num = Number(num);
    for (let i = num; i > 0; i--) {
        console.log(i);
    }
}

function PrintLines(lines) {
    for (let line of lines) {
        if (line === "Stop") {break}
        console.log(line);
    }
}

PrintLines(['1','2','4','Stop','rrr'])
