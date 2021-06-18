import d3

X = [1,2,3,4,5,6,7,8,9]

console.log(d3.sum(d3.map(X,function(d,i){return d*i})))
