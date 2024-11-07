This project demonstrates Node Id deserialization failure in Hotchocolate 14.1.0.

Downgrading to 13.9.14 fixes the issue.

## Steps to reproduce
1. Run the project
2. Run the [query](Interactions.gql)
3. Retrieve the `id` from the response
4. Run the [mutation](Interactions.gql) with the retrieved `id`
5. Observe the `The node ID string has an invalid format.` error