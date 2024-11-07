This project demonstrates a Cost Analysis issue with variables in Hotchocolate 14.1.0.

## Steps to reproduce
1. Run the project
2. Run the query
```
query queryVariable($count: Int) {
    myThings(id: "", first: $count, after: null, last: null, before: null) {
        nodes {
            id
            identifier
        }
    }
}
```
With variable:
```
{
    "count": 100
}
```
3. Observe the `The maximum allowed type cost was exceeded.` error
4Run the query
```
query queryDirect {
  myThings(id: "", first: 100, after: null, last: null, before: null) {
    nodes {
      id
      identifier
    }
  }
}
```
6. Observer the successful result
