# Challenges

## Keep the App free of library references 
Each library belonging to the project should bring it's dependend libraries and they should work only against abstractions.

## Describe the whole behaviour of the Domain Model as commands and events

Commands should be either valid or not accessible on the current state of the aggregate later this might lead to an user interface which gets rendered based on the available commands.

CommandHandler implementations should be introduced to implement the intent of corresponding commands and publish events

within CommandHandlers Unit of Work and Repository pattern should be used to abstract from specific persistence technologiess

## Apply cqrs consequently

Aggregates / Entities state should be create lazy from it's event stream.
Which leads to the question on how to mitigate side effects like sending an email on the replay of an aggregates state.
Thought might it be possible to use a stack based approach... 
Example on replay:
Email has been send on an event A 
Replay reaches the command causing the email (side effect on outside world)
the command itself gets pushed on the stack replay continues until the Email sent event is reachend command gets popped without execution?
this will only work as long their are no more side effects could be caused in parallel!?

Later some kind of snapshoting needs to be introduced.