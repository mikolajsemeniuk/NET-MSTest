# MSTests
quick start:
```sh
mkdir Test && cd Test
dotnet new sln -n Test

dotnet new mstest -o source/Tests
dotnet new console -o source/Logic

dotnet sln add source/Tests
dotnet sln add source/Logic

dotnet add source/Tests reference source/Logic
dotnet test
```
all:
```sh
dotnet test source/Tests
```
single:
```sh
dotnet test source/Tests --filter TestIsException
```
Runs tests whose name contains `Test`.
```sh
dotnet test source/Tests --filter Name~Test
```
Runs tests that are in class `Tests.UnitTest1`.
```sh
dotnet test source/Tests --filter ClassName=Tests.UnitTest1
```
Runs all tests except `Tests.UnitTest1.TestAreEqual`.
```sh
dotnet test source/Tests --filter FullyQualifiedName!=Tests.UnitTest1.TestAreEqual
```
Runs tests that are annotated with `[TestCategory("CategoryA")]`.
```sh
dotnet test source/Tests --filter TestCategory=CategoryA
```
Runs tests that are annotated with `[Priority(2)]`.
```sh
dotnet test source/Tests --filter Priority=2
```
Runs tests that are annotated with `[TestCategory("CategoryA")]` and `[Priority(1)]`.
```sh
dotnet test source/Tests --filter "TestCategory=CategoryA&Priority=1"
```
Runs tests that are annotated with `[TestCategory("CategoryA")]` or `[Priority(2)]`.
```sh
dotnet test source/Tests --filter "TestCategory=CategoryA|Priority=2"
```
Runs tests that are annotated with `Test` name and `[TestCategory("CategoryA")]` or `[Priority(2)]`.
```sh
dotnet test --filter "(FullyQualifiedName~Test&TestCategory=CategoryA)|Priority=2"
```# NET-MSTest
