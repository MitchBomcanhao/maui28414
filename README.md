showcases https://github.com/dotnet/maui/issues/28414
1. start app
2. press button to go to second page
3. press button to go to third page
4. press the back button on the top left
5. OBSERVE
   - on iOS, the navigation stack will still have all 3 pages when the OnAppearing method for the SecondPage is called.
   - on Android and Windows it'll only have 2 pages, as expected. 
