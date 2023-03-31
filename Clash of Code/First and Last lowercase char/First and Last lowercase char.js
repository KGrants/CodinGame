const message = readline();

console.error(message)
console.log(message.split('').find(e => e.charCodeAt(0) >= 97 && e.charCodeAt(0) <= 122 )+"-"+message.split('').reverse().find(e => e.charCodeAt(0) >= 97 && e.charCodeAt(0) <= 122 ));
