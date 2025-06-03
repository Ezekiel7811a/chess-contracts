# What it is

The contracts are interfaces our classes implementations need to implement. It allows working independently from each other but with the same contracts so that a system will work with another system.

# How can I use it

You need to create a directory on your PC and do the following

-   git init
-   git remote add origin https://github.com/Ezekiel7811a/chess-contracts.git
-   git pull origin master

This will pull all the necessary contracts, then if you want to use it in another csproj. Insert the following inside your csproj /!\ you need to change the path.

```xml
<ItemGroup>
    <Compile Include="..\PathToRuntime\**\*.cs">
        <Link>
        ChessContracts\%(RecursiveDir)%(Filename)%(Extension)
        <Link>
    </Compile>
</ItemGroup>
```

# What if I need to change an interface

If you need to change an interface you should make a pull request and ask me (Ezekiel) to review it.
