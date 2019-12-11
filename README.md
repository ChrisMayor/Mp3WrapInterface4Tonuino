# Mp3WrapInterface4Tonuino
Interface for mp3wrap to convert mp3s to correct format for the Tonunio https://www.voss.earth/tonuino/

Requirements:

* .NET Framework 4.7.2
* mp3wrap (http://mp3wrap.sourceforge.net/)

## Documentation / Quick start currently in work

<img src ="https://github.com/ChrisMayor/Mp3WrapInterface4Tonuino/blob/master/Screenshots/ton4.JPG"/>

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
