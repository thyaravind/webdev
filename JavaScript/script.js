


//data types and declaration

//numbers
var a = 2
var b = 3.2
c = 32

//strings
name = 'aravind'

//Arrays
var Ar = new Array()
Ara = ['this is an array', 'it can hold various data type objects', 3,4,5, 'aravind',['another array','of sixe two']]

//bool
//dynamic assignment
c = true

//date object

dat = Date()

console.log(a,b,c,Ar,Ara[3],c == false)


document.body.innerHTML = '<h2>My name is '+ name +' and the time now is '+ dat+ '</h2>'



if (a==b){
  console.log('a is equal to b')
}
else {console.log('a is not equal to b')}


if (a==b || a!=b){
  console.log('a is equal to b')
}
else {console.log('a is not equal to b')}


//terinary operator - if comprehension

a == b ? console.log('a is equal to b') : console.log('a is not equal to b')




//function types

function sam(a,b){
  return a+b
}

sumvalue = sam(1,3)
console.log(sumvalue)


//anonymous function

sumanonymous = function(a,b){
  return a+b
}

console.log(sumanonymous(2,3))



//Instantly invoked function
suminstant = (function(a,b){ return a+b})(3,3)
console.log(suminstant)
