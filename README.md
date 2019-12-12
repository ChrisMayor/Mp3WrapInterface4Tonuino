[![Build Status](https://dev.azure.com/ich0166/Mp3WrapInterface4Tonuino/_apis/build/status/ChrisMayor.Mp3WrapInterface4Tonuino?branchName=master)](https://dev.azure.com/ich0166/Mp3WrapInterface4Tonuino/_build/latest?definitionId=6&branchName=master)
# Mp3WrapInterface4Tonuino
Interface for mp3wrap to convert mp3s to correct format for the Tonunio https://www.voss.earth/tonuino/

Requirements:

* .NET Framework 4.7.2
* mp3wrap (http://mp3wrap.sourceforge.net/)

## Download binary for Windows 0.5

https://github.com/ChrisMayor/Mp3WrapInterface4Tonuino/blob/master/Releases/0.5/Mp3WrapInterface4Tonunio.zip

## Documentation / Quick start

<img src ="https://github.com/ChrisMayor/Mp3WrapInterface4Tonuino/blob/master/Screenshots/ton.jpg"/>

* No error handling
* logging in logfile.txt (application directory)

Hint: Directories with a length > 256 are still not supported by default in Windows and may result in an application exception

### Option 1 - Hörspielmodus / Audio book mode:

* Scans the subfolders of the input folder for mp3s
* If mp3s are found, the folder will be copied to output folder
* Then all mp3s in folder will be merged to one with mp3wrap

#### Input folder:

```
MyAudioBooks(InputFolder) 
│
└───ChristmasAudioBooks
│   │
│   └──Tales from Rudi the Reindeer
│       │   001 - Intro.mp3
│       │   002 - ChristmasStory.mp3
│       │   003 - Outro.mp3
│   └──In love with the Grinch
│       │   001 - Intro.mp3
│       │   002 - SomeStory.mp3
│       │   003 - Outro.mp3
│   
└───The Graduate - The Audiobook
    │   001 - Intro.mp3
    │   002 - SomeStory.mp3
    │   003 - Outro.mp3
```

#### Output folder (Result):

```
MyPreparedAudiobooks(OutputFolder) 
│
└───Tales from Rudi the Reindeer
│   │   001.mp3
└────In love with the Grinch
│   │   001.mp3
└───The Graduate - The Audiobook
    │   001.mp3
```

### Option 2: Albummodus / Album mode

* Scans the subfolders of the input folder for mp3s
* If mp3s are found, the folder will be copied to output folder
* Then all mp3s in folder will numbered ascending from 001.mp3 to xxx.mp3 

#### Input folder:

```
MyAudioBooks(InputFolder) 
│
└───ChristmasMusic
│   │
│   └──Singing with Rudi the Reindeer
│       │   001 - Oh christmas tree.mp3
│       │   002 - Jingle bells.mp3
│       │   003 - White christmas.mp3
│   └──Dancing with the Grinch
│       │   001 - Joy to the world.mp3
│       │   002 - Winter wonderland.mp3
│       │   003 - Rudolph the red nose r.mp3
│   
└───The Elves - Hevy Metal
    │   001 - Heavy metal christmas.mp3
    │   002 - Hard rock egg nog.mp3
    │   003 - Jingle guitar.mp3
```

#### Output folder (Result):

```
MyPreparedAudiobooks(OutputFolder) 
│
└───Singing with Rudi the Reindeer
│   │   001.mp3
│   │   002.mp3
│   │   003.mp3
└────Dancing with the Grinch
│   │   001.mp3
│   │   002.mp3
│   │   003.mp3
└───The Elves - Hevy Metal
    │   001.mp3
    │   002.mp3
    │   003.mp3
```

### Option 3: Number folders

* Numbers the directories in the output folder ascending (01 - xx)
* The starting number can be entered at the UI
#### Input folder (Output in UI):

```
MyPreparedAudiobooks(OutputFolder) 
│
└───Singing with Rudi the Reindeer
│   │   001.mp3
│   │   002.mp3
│   │   003.mp3
└────Dancing with the Grinch
│   │   001.mp3
│   │   002.mp3
│   │   003.mp3
└───The Elves - Hevy Metal
    │   001.mp3
    │   002.mp3
    │   003.mp3
```

#### Output folder (Result):

```
MyPreparedAudiobooks(OutputFolder) 
│
└───01
│   │   001.mp3
│   │   002.mp3
│   │   003.mp3
└────02
│   │   001.mp3
│   │   002.mp3
│   │   003.mp3
└───03
    │   001.mp3
    │   002.mp3
    │   003.mp3
```


## Disclaimer / Impressum

* Published under the MIT license
* Use at your own risk

<a href="https://github.com/ChrisMayor/Impressum">Impressum / Imprint in German language to comply with German tele-media regulations.</a>
