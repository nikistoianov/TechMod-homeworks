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

function PrintReversed(lines) {
    for (let i = lines.length - 1; i >= 0; i--) {
        console.log(lines[i]);
    }
}

function SetValuesToIndexesArray(lines) {
    let arrLen = Number(lines[0]);
    let arr = Array.from('0' .repeat(arrLen));

    for (let i = 1; i < lines.length; i++) {
        let split = lines[i].split(" - ");

        arr[Number(split[0])] = split[1];
    }

    for (let element of arr) {
        console.log(element);
    }
}

function AddRemoveElements(lines) {
    let arr = [];
    for (let line of lines) {
        let split = line.split(' ');
        if (split[0] == "add") {
            arr.push(split[1])
        } else if (split[0] == "remove") {
            arr.splice(Number(split[1]), 1)
        }
    }

    for (let element of arr) {
        console.log(element);
    }
}

function WorkingWithKeyValuePairs(lines) {
    let dict = {};
    for (let i = 0; i < lines.length - 1; i++) {
        let split = lines[i].split(' ');
        dict[split[0]] = split[1];
    }

    let lastKey = lines[lines.length - 1];
    if (lastKey in dict) {
        console.log(dict[lastKey]);
    } else {
        console.log('None');
    }
}

function MultipleValuesForKey(lines) {
    let dict = {};
    for (let i = 0; i < lines.length - 1; i++) {
        let split = lines[i].split(' ');
        if (split[0] in dict) {
            dict[split[0]].push(split[1]);
        } else {
            dict[split[0]] = [split[1]];
        }
    }

    let lastKey = lines[lines.length - 1];
    if (lastKey in dict) {
        for (let element of dict[lastKey]) {
            console.log(element);
        }
    } else {
        console.log('None');
    }
}

function StoringObjects(lines) {
    let students = [];
    for (let line of lines) {
        let split = line.split(' -> ');
        students.push({ name : split[0], age : split[1], grade : split[2]})
    }

    for (let student of students) {
        console.log("Name: " + student['name']);
        console.log("Age: " + student['age']);
        console.log("Grade: " + student['grade']);
    }
}

function ParseJSONObjects(lines) {
    let students = [];
    for (let line of lines) {
        let student = JSON.parse(line);
        students.push(student)
    }

    for (let student of students) {
        console.log("Name: " + student['name']);
        console.log("Age: " + student['age']);
        console.log("Date: " + student['date']);
    }
}

function TurnObjectIntoJSONString(lines) {
    let dict = {};
    for (let line of lines) {
        let split = line.split(' -> ');
        let value = Number(split[1]);
        if (Number.isNaN(value)) {
            value = split[1];
        }
        dict[split[0]] = value;
    }
    let str = JSON.stringify(dict);
    console.log(str);
}

TurnObjectIntoJSONString(['name -> Angel', 'surname -> Georgiev', 'age -> 20', 'grade -> 6.00'])
