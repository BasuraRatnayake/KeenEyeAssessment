function FindEvenNumbers(numbers) {
  if (!(numbers instanceof Array)) throw "Only Arrays Are Allowed.";

  let evenNumbers = [];

  const length = numbers.length;
  for (let i = 0; i < length; i++) {
    let num = numbers[i];
    if (num % 2 == 0) evenNumbers.push(num);
  }

  return evenNumbers;
}
