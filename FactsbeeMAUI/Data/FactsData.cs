using FactsbeeMAUI.Models;

namespace FactsbeeMAUI.Data
{
    public static class FactsData
    {
        private static IEnumerable<FactModel> _facts;
        public static IEnumerable<FactModel> Facts => _facts ??= LoadFacts();

        public static IEnumerable<FactModel> LoadFacts()
        {
            var facts = new List<FactModel>
            {
                new FactModel(
                1,
                "Every person has a unique tongue print as well as fingerprints.",
                "Every-person-has-a-unique-tongue-print-as-well-as-fingerprints",
                "Every person has a unique tongue print as well as fingerprints.",
                "Human"
              ),
              new FactModel(
                2,
                "Because metal was scarce, the Oscars given out during World War II were made",
                "Because-metal-was-scarce-the-Oscars-given-out-during-World-War-II-were-made",
                "Because metal was scarce, the Oscars given out during World War II were made of wood.",
                "Misc"
              ),
              new FactModel(
                3,
                "There are more chickens than people in the world (at least before that chicke",
                "There-are-more-chickens-than-people-in-the-world-at-least-before-that-chicke",
                "There are more chickens than people in the world (at least before that chicken-flu thing).",
                "Animal"
              ),
              new FactModel(
                4,
                "The glue on Israeli postage stamps is certified kosher.",
                "The-glue-on-Israeli-postage-stamps-is-certified-kosher",
                "The glue on Israeli postage stamps is certified kosher.",
                "Misc"
              ),
              new FactModel(
                5,
                "Winston Churchill was born in a ladies' room during a dance.",
                "Winston-Churchill-was-born-in-a-ladies-room-during-a-dance",
                "Winston Churchill was born in a ladies' room during a dance.",
                "Misc"
              ),
              new FactModel(
                6,
                "Honey is the only food that doesn't spoil.",
                "Honey-is-the-only-food-that-doesn-t-spoil",
                "Honey is the only food that doesn't spoil.",
                "Misc"
              ),
              new FactModel(
                7,
                "Your ribs move about 5 million times a year, everytime you breathe!",
                "Your-ribs-move-about-5-million-times-a-year-everytime-you-breathe",
                "Your ribs move about 5 million times a year, everytime you breathe!",
                "Human"
              ),
              new FactModel(
                8,
                "Each year there is one ton of cement poured for each man woman and child in t",
                "Each-year-there-is-one-ton-of-cement-poured-for-each-man-woman-and-child-in-t",
                "Each year there is one ton of cement poured for each man woman and child in the world.",
                "Misc"
              ),
              new FactModel(
                9,
                "Who's that playing the piano on the 'Mad About You' theme?  Paul Reiser himse",
                "Who-s-that-playing-the-piano-on-the-Mad-About-You-theme- -Paul-Reiser-himse",
                "Who's that playing the piano on the 'Mad About You' theme?  Paul Reiser himself.",
                "Entertainment"
              ),
              new FactModel(
                10,
                "The average secretary's left hand does 56% of the typing.",
                "The-average-secretary-s-left-hand-does-56-of-the-typing",
                "The average secretary's left hand does 56% of the typing.",
                "Misc"
              ),
              new FactModel(
                11,
                "Every day more money is printed for monopoly than the US Treasury.",
                "Every-day-more-money-is-printed-for-monopoly-than-the-US-Treasury",
                "Every day more money is printed for monopoly than the US Treasury.",
                "Misc"
              ),
              new FactModel(
                12,
                "Humans are the only primates that don't have pigment in the palms of their ha",
                "Humans-are-the-only-primates-that-don-t-have-pigment-in-the-palms-of-their-ha",
                "Humans are the only primates that don't have pigment in the palms of their hands.",
                "Human"
              ),
              new FactModel(
                13,
                "A giraffe can clean its ears with its 21-inch tongue!",
                "A-giraffe-can-clean-its-ears-with-its-21-inch-tongue",
                "A giraffe can clean its ears with its 21-inch tongue!",
                "Animal"
              ),
              new FactModel(
                14,
                "'Rhythm' is the longest English word without a vowel.",
                "Rhythm-is-the-longest-English-word-without-a-vowel",
                "'Rhythm' is the longest English word without a vowel.",
                "Word & Language"
              ),
              new FactModel(
                15,
                "The elephant is the only mammal that can’t jump!",
                "The-elephant-is-the-only-mammal-that-can’t-jump",
                "The elephant is the only mammal that can’t jump!",
                "Animal"
              ),
              new FactModel(
                16,
                "Each of us generates about 3.5 pounds of rubbish a day, most of it paper.",
                "Each-of-us-generates-about-3-5-pounds-of-rubbish-a-day-most-of-it-paper",
                "Each of us generates about 3.5 pounds of rubbish a day, most of it paper.",
                "Misc"
              ),
              new FactModel(
                17,
                "Chinese Crested dogs can get acne.",
                "Chinese-Crested-dogs-can-get-acne",
                "Chinese Crested dogs can get acne.",
                "Animal"
              ),
              new FactModel(
                18,
                "Your stomach produces a new layer of mucus every two weeks - otherwise it wil",
                "Your-stomach-produces-a-new-layer-of-mucus-every-two-weeks--otherwise-it-wil",
                "Your stomach produces a new layer of mucus every two weeks - otherwise it will digest itself.",
                "Misc"
              ),
              new FactModel(
                19,
                "If NASA sent birds into space they would soon die; they need gravity to swall",
                "If-NASA-sent-birds-into-space-they-would-soon-die-they-need-gravity-to-swall",
                "If NASA sent birds into space they would soon die; they need gravity to swallow.",
                "Science & Technology"
              ),
              new FactModel(
                20,
                "'Dreamt' is the only English word that ends in the letters 'mt'.",
                "Dreamt-is-the-only-English-word-that-ends-in-the-letters-mt",
                "'Dreamt' is the only English word that ends in the letters 'mt'.",
                "Word & Language"
              ),
              new FactModel(
                21,
                "The placement of a donkey’s eyes in its’ heads enables it to see all four fee",
                "The-placement-of-a-donkey’s-eyes-in-its’-heads-enables-it-to-see-all-four-fee",
                "The placement of a donkey’s eyes in its’ heads enables it to see all four feet at all times!",
                "Animal"
              ),
              new FactModel(
                22,
                "Ten percent of the Russian government's income comes from the sale of vodka.",
                "Ten-percent-of-the-Russian-government-s-income-comes-from-the-sale-of-vodka",
                "Ten percent of the Russian government's income comes from the sale of vodka.",
                "Misc"
              ),
              new FactModel(
                23,
                "An ostrich's eye is bigger that it's brain.",
                "An-ostrich-s-eye-is-bigger-that-it-s-brain",
                "An ostrich's eye is bigger that it's brain.",
                "Animal"
              ),
              new FactModel(
                24,
                "Ten percent of the Russian government's income comes from the sale of vodka.",
                "Ten-percent-of-the-Russian-government-s-income-comes-from-the-sale-of-vodka",
                "Ten percent of the Russian government's income comes from the sale of vodka.",
                "Misc"
              ),
              new FactModel(
                25,
                "Of all the words in the English language, the word 'set' has the most definit",
                "Of-all-the-words-in-the-English-language-the-word-set-has-the-most-definit",
                "Of all the words in the English language, the word 'set' has the most definitions!",
                "Word & Language"
              ),
              new FactModel(
                26,
                "Mel Blanc (the voice of Bugs Bunny) was allergic to carrots.",
                "Mel-Blanc-the-voice-of-Bugs-Bunny-was-allergic-to-carrots",
                "Mel Blanc (the voice of Bugs Bunny) was allergic to carrots.",
                "Entertainment"
              ),
              new FactModel(
                27,
                "The youngest Pope was 11 years old.",
                "The-youngest-Pope-was-11-years-old",
                "The youngest Pope was 11 years old.",
                "Misc"
              ),
              new FactModel(
                28,
                "Pepsi originally contained pepsin, thus the name.",
                "Pepsi-originally-contained-pepsin-thus-the-name",
                "Pepsi originally contained pepsin, thus the name.",
                "Misc"
              ),
              new FactModel(
                29,
                "The slogan on New Hampshire license plates is 'Live Free or Die.'  These lice",
                "The-slogan-on-New-Hampshire-license-plates-is-Live-Free-or-Die- -These-lice",
                "The slogan on New Hampshire license plates is 'Live Free or Die.'  These license plates are manufactured by prisoners in the state prison in Concord.",
                "Misc"
              ),
              new FactModel(
                30,
                "The most common name in the world is Mohammed.",
                "The-most-common-name-in-the-world-is-Mohammed",
                "The most common name in the world is Mohammed.",
                "Misc"
              ),
              new FactModel(
                31,
                "When the University of Nebraska Cornhuskers play football at home, the stadiu",
                "When-the-University-of-Nebraska-Cornhuskers-play-football-at-home-the-stadiu",
                "When the University of Nebraska Cornhuskers play football at home, the stadium becomes the state's third largest city.",
                "Misc"
              ),
              new FactModel(
                32,
                "Most dust particles in your house are made from dead skin!",
                "Most-dust-particles-in-your-house-are-made-from-dead-skin",
                "Most dust particles in your house are made from dead skin!",
                "Misc"
              ),
              new FactModel(
                33,
                "The national anthem of Greece has 158 verses.  No one in Greece has memorized",
                "The-national-anthem-of-Greece-has-158-verses- -No-one-in-Greece-has-memorized",
                "The national anthem of Greece has 158 verses.  No one in Greece has memorized all 158 verses.",
                "Misc"
              ),
              new FactModel(
                34,
                "'Dreamt' is the only English word that ends in the letters 'mt'.",
                "Dreamt-is-the-only-English-word-that-ends-in-the-letters-mt",
                "'Dreamt' is the only English word that ends in the letters 'mt'.",
                "Word & Language"
              ),
              new FactModel(
                35,
                "There are 336 dimples on a regulation golf ball.",
                "There-are-336-dimples-on-a-regulation-golf-ball",
                "There are 336 dimples on a regulation golf ball.",
                "Misc"
              ),
              new FactModel(
                36,
                "The strongest muscle in proportion to its size in the human body is the tongu",
                "The-strongest-muscle-in-proportion-to-its-size-in-the-human-body-is-the-tongu",
                "The strongest muscle in proportion to its size in the human body is the tongue.",
                "Human"
              ),
              new FactModel(
                37,
                "Wearing headphones for just an hour will increase the bacteria in your ear by",
                "Wearing-headphones-for-just-an-hour-will-increase-the-bacteria-in-your-ear-by",
                "Wearing headphones for just an hour will increase the bacteria in your ear by 700 times.",
                "Misc"
              ),
              new FactModel(
                38,
                "Fingernails grow nearly 4 times faster than toenails!",
                "Fingernails-grow-nearly-4-times-faster-than-toenails",
                "Fingernails grow nearly 4 times faster than toenails!",
                "Misc"
              ),
              new FactModel(
                39,
                "Pearls melt in vinegar.",
                "Pearls-melt-in-vinegar",
                "Pearls melt in vinegar.",
                "Misc"
              ),
              new FactModel(
                40,
                "One quarter of the bones in your body, are in your feet!",
                "One-quarter-of-the-bones-in-your-body-are-in-your-feet",
                "One quarter of the bones in your body, are in your feet!",
                "Human"
              ),
              new FactModel(
                41,
                "The world's termites outweigh the world's humans 10 to 1.",
                "The-world-s-termites-outweigh-the-world-s-humans-10-to-1",
                "The world's termites outweigh the world's humans 10 to 1.",
                "Misc"
              ),
              new FactModel(
                42,
                "In 'Casablanca', Humphrey Bogart never said 'Play it again, Sam'.",
                "In-Casablanca--Humphrey-Bogart-never-said-Play-it-again-Sam",
                "In 'Casablanca', Humphrey Bogart never said 'Play it again, Sam'.",
                "Entertainment"
              ),
              new FactModel(
                43,
                "Percentage of Africa that is wilderness: 28% Percentage of North America that",
                "Percentage-of-Africa-that-is-wilderness-28-Percentage-of-North-America-that",
                "Percentage of Africa that is wilderness: 28% Percentage of North America that is wilderness: 38%",
                "Misc"
              ),
              new FactModel(
                44,
                "A man named Charles Osborne had the hiccups for 69 years!",
                "A-man-named-Charles-Osborne-had-the-hiccups-for-69-years",
                "A man named Charles Osborne had the hiccups for 69 years!",
                "Human"
              ),
              new FactModel(
                45,
                "A shrimp's heart is in it's head.",
                "A-shrimp-s-heart-is-in-it-s-head",
                "A shrimp's heart is in it's head.",
                "Animal"
              ),
              new FactModel(
                46,
                "Babies are born without kneecaps. They don't appear until the child reaches 2",
                "Babies-are-born-without-kneecaps-They-don-t-appear-until-the-child-reaches-2",
                "Babies are born without kneecaps. They don't appear until the child reaches 2-6 years of age.",
                "Human"
              ),
              new FactModel(
                47,
                "In 1386, a pig in France was executed by public hanging for the murder of a c",
                "In-1386-a-pig-in-France-was-executed-by-public-hanging-for-the-murder-of-a-c",
                "In 1386, a pig in France was executed by public hanging for the murder of a child",
                "Misc"
              ),
              new FactModel(
                48,
                "If you keep your eyes open by force when you sneeze, you might pop an eyeball",
                "If-you-keep-your-eyes-open-by-force-when-you-sneeze-you-might-pop-an-eyeball",
                "If you keep your eyes open by force when you sneeze, you might pop an eyeball out.",
                "Human"
              ),
              new FactModel(
                49,
                "Human thigh bones are stronger than concrete.",
                "Human-thigh-bones-are-stronger-than-concrete",
                "Human thigh bones are stronger than concrete.",
                "Human"
              ),
              new FactModel(
                50,
                "The very first bomb dropped by the Allies on Berlin during World War II kille",
                "The-very-first-bomb-dropped-by-the-Allies-on-Berlin-during-World-War-II-kille",
                "The very first bomb dropped by the Allies on Berlin during World War II killed the only elephant in the Berlin Zoo.",
                "Misc"
              ),
              new FactModel(
                51,
                "Most American car horns honk in the key of F.",
                "Most-American-car-horns-honk-in-the-key-of-F",
                "Most American car horns honk in the key of F.",
                "Misc"
              ),
              new FactModel(
                52,
                "The Declaration of Independence was written on hemp paper.",
                "The-Declaration-of-Independence-was-written-on-hemp-paper",
                "The Declaration of Independence was written on hemp paper.",
                "Misc"
              ),
              new FactModel(
                53,
                "The female lion does ninety percent of the hunting.",
                "The-female-lion-does-ninety-percent-of-the-hunting",
                "The female lion does ninety percent of the hunting.",
                "Animal"
              ),
              new FactModel(
                54,
                "Your stomach produces a new layer of mucus every two weeks - otherwise it wil",
                "Your-stomach-produces-a-new-layer-of-mucus-every-two-weeks--otherwise-it-wil",
                "Your stomach produces a new layer of mucus every two weeks - otherwise it will digest itself.",
                "Misc"
              ),
              new FactModel(
                55,
                "Tigers have striped skin, not just striped fur.",
                "Tigers-have-striped-skin-not-just-striped-fur",
                "Tigers have striped skin, not just striped fur.",
                "Animal"
              ),
              new FactModel(
                56,
                "According to the Wall Street Journal, the cockfighting market is huge: The Ph",
                "According-to-the-Wall-Street-Journal-the-cockfighting-market-is-huge-The-Ph",
                "According to the Wall Street Journal, the cockfighting market is huge: The Philippines has five million roosters used for exactly that.",
                "Misc"
              ),
              new FactModel(
                57,
                "Warren Beatty and Shirley MacLaine are brother and sister.",
                "Warren-Beatty-and-Shirley-MacLaine-are-brother-and-sister",
                "Warren Beatty and Shirley MacLaine are brother and sister.",
                "Entertainment"
              ),
              new FactModel(
                58,
                "The cigarette lighter was invented before the match.",
                "The-cigarette-lighter-was-invented-before-the-match",
                "The cigarette lighter was invented before the match.",
                "Misc"
              ),
              new FactModel(
                59,
                "In England, the Speaker of the House is not allowed to speak.",
                "In-England-the-Speaker-of-the-House-is-not-allowed-to-speak",
                "In England, the Speaker of the House is not allowed to speak.",
                "Misc"
              ),
              new FactModel(
                60,
                "Gopher snakes in Arizona are not poisonous, but when frightened they may hiss",
                "Gopher-snakes-in-Arizona-are-not-poisonous-but-when-frightened-they-may-hiss",
                "Gopher snakes in Arizona are not poisonous, but when frightened they may hiss and shake their tails like rattlesnakes.",
                "Animal"
              ),
              new FactModel(
                61,
                "The name Jeep came from the abbreviation used in the army for the 'General Pu",
                "The-name-Jeep-came-from-the-abbreviation-used-in-the-army-for-the-General-Pu",
                "The name Jeep came from the abbreviation used in the army for the 'General Purpose' vehicle, G.P.",
                "Misc"
              ),
              new FactModel(
                62,
                "You can’t kill yourself by holding your breath",
                "You-can’t-kill-yourself-by-holding-your-breath",
                "You can’t kill yourself by holding your breath",
                "Human"
              ),
              new FactModel(
                63,
                "The longest place name still in use is: Taumatawhakatangihangaoauauotam-eteat",
                "The-longest-place-name-still-in-use-is-Taumatawhakatangihangaoauauotam-eteat",
                "The longest place name still in use is: Taumatawhakatangihangaoauauotam-eteaturipukakapikimaungahoronukupokai-whenu a kitanatahu - a New Zealand hill.",
                "Word & Language"
              ),
              new FactModel(
                64,
                "A chip of silicon a quarter-inch square has the capacity of the original 1949",
                "A-chip-of-silicon-a-quarter-inch-square-has-the-capacity-of-the-original-1949",
                "A chip of silicon a quarter-inch square has the capacity of the original 1949 ENIAC computer, which occupied a city block.",
                "Science & Technology"
              ),
              new FactModel(
                65,
                "The longest one-syllable word in the English language is 'screeched.'",
                "The-longest-one-syllable-word-in-the-English-language-is-screeched",
                "The longest one-syllable word in the English language is 'screeched.'",
                "Word & Language"
              ),
              new FactModel(
                66,
                "111,111,111 x 111,111,111 = 12,345,678,987,654,321",
                "111-111-111-x-111-111-111-=-12-345-678-987-654-321",
                "111,111,111 x 111,111,111 = 12,345,678,987,654,321",
                "Misc"
              ),
              new FactModel(
                67,
                "Thirty-five percent of the people who use personal ads for dating are already",
                "Thirty-five-percent-of-the-people-who-use-personal-ads-for-dating-are-already",
                "Thirty-five percent of the people who use personal ads for dating are already married.",
                "Human"
              ),
              new FactModel(
                68,
                "Rubber bands last longer when refrigerated.",
                "Rubber-bands-last-longer-when-refrigerated",
                "Rubber bands last longer when refrigerated.",
                "Misc"
              ),
              new FactModel(
                69,
                "Barbie's measurements if she were life size: 39-23-33",
                "Barbie-s-measurements-if-she-were-life-size-39-23-33",
                "Barbie's measurements if she were life size: 39-23-33",
                "Entertainment"
              ),
              new FactModel(
                70,
                "Most collect calls are made on father's day.",
                "Most-collect-calls-are-made-on-father-s-day",
                " Most collect calls are made on father's day.",
                "Misc"
              ),
              new FactModel(
                71,
                "Coca-Cola would be green if colouring weren’t added to it.",
                "Coca-Cola-would-be-green-if-colouring-weren’t-added-to-it",
                "Coca-Cola would be green if colouring weren’t added to it.",
                "Misc"
              ),
              new FactModel(
                72,
                "Young beavers stay with their parents for the first two years of their lives",
                "Young-beavers-stay-with-their-parents-for-the-first-two-years-of-their-lives",
                "Young beavers stay with their parents for the first two years of their lives before going out on their own.",
                "Animal"
              ),
              new FactModel(
                73,
                "In Cleveland, Ohio, it's illegal to catch mice without a hunting license.",
                "In-Cleveland-Ohio-it-s-illegal-to-catch-mice-without-a-hunting-license",
                "In Cleveland, Ohio, it's illegal to catch mice without a hunting license.",
                "Misc"
              ),
              new FactModel(
                74,
                "All of the clocks in the movie 'Pulp Fiction' are stuck on 4:20.",
                "All-of-the-clocks-in-the-movie-Pulp-Fiction-are-stuck-on-4-20",
                "All of the clocks in the movie 'Pulp Fiction' are stuck on 4:20.",
                "Entertainment"
              ),
              new FactModel(
                75,
                "The volume of the Earth's moon is the same as the volume of the Pacific Ocean",
                "The-volume-of-the-Earth-s-moon-is-the-same-as-the-volume-of-the-Pacific-Ocean",
                "The volume of the Earth's moon is the same as the volume of the Pacific Ocean.",
                "Misc"
              ),
              new FactModel(
                76,
                "Your heart beats over 100,000 times a day.",
                "Your-heart-beats-over-100-000-times-a-day",
                "Your heart beats over 100,000 times a day.",
                "Misc"
              ),
              new FactModel(
                77,
                "There are only four words in the English language which end in 'dous': tremen",
                "There-are-only-four-words-in-the-English-language-which-end-in-dous--tremen",
                "There are only four words in the English language which end in 'dous': tremendous, horrendous, stupendous, and hazardous.",
                "Word & Language"
              ),
              new FactModel(
                78,
                "It is impossible to sneeze with your eyes open",
                "It-is-impossible-to-sneeze-with-your-eyes-open",
                "It is impossible to sneeze with your eyes open",
                "Misc"
              ),
              new FactModel(
                79,
                "If you put a raisin in a glass of champagne, it will keep floating to the top",
                "If-you-put-a-raisin-in-a-glass-of-champagne-it-will-keep-floating-to-the-top",
                "If you put a raisin in a glass of champagne, it will keep floating to the top and sinking to the bottom.",
                "Misc"
              ),
              new FactModel(
                80,
                "Right-handed people live, on average; nine years longer than left handed peop",
                "Right-handed-people-live-on-average-nine-years-longer-than-left-handed-peop",
                "Right-handed people live, on average; nine years longer than left handed people.",
                "Human"
              ),
              new FactModel(
                81,
                "Hydrogen gas is the least dense substance in the world, at 0.08988g/cc.  Hydr",
                "Hydrogen-gas-is-the-least-dense-substance-in-the-world-at-0-08988g-cc- -Hydr",
                "Hydrogen gas is the least dense substance in the world, at 0.08988g/cc.  Hydrogen solid is the most dense substance in the world, at 70.6g/cc.",
                "Science & Technology"
              ),
              new FactModel(
                82,
                "Some worms will eat themselves if they can’t find any food!",
                "Some-worms-will-eat-themselves-if-they-can’t-find-any-food",
                "Some worms will eat themselves if they can’t find any food!",
                "Animal"
              ),
              new FactModel(
                83,
                "More people are allergic to cow’s milk than any other food.",
                "More-people-are-allergic-to-cow’s-milk-than-any-other-food",
                "More people are allergic to cow’s milk than any other food.",
                "Misc"
              ),
              new FactModel(
                84,
                "No word in the English language rhymes with month, orange, silver or purple.",
                "No-word-in-the-English-language-rhymes-with-month-orange-silver-or-purple",
                "No word in the English language rhymes with month, orange, silver or purple.",
                "Word & Language"
              ),
              new FactModel(
                85,
                "A dime has 118 ridges around the edge.",
                "A-dime-has-118-ridges-around-the-edge",
                "A dime has 118 ridges around the edge.",
                "Animal"
              ),
              new FactModel(
                86,
                "The placement of a donkey’s eyes in its’ heads enables it to see all four fee",
                "The-placement-of-a-donkey’s-eyes-in-its’-heads-enables-it-to-see-all-four-fee",
                "The placement of a donkey’s eyes in its’ heads enables it to see all four feet at all times!",
                "Animal"
              ),
              new FactModel(
                87,
                "The most common name in the world is Mohammed.",
                "The-most-common-name-in-the-world-is-Mohammed",
                "The most common name in the world is Mohammed.",
                "Misc"
              ),
              new FactModel(
                88,
                "The mask used by Michael Myers in the original 'Halloween' was a Captain Kirk",
                "The-mask-used-by-Michael-Myers-in-the-original-Halloween-was-a-Captain-Kirk",
                "The mask used by Michael Myers in the original 'Halloween' was a Captain Kirk mask painted white.",
                "Misc"
              ),
              new FactModel(
                89,
                "No word in the English language rhymes with month, orange, silver, and purple",
                "No-word-in-the-English-language-rhymes-with-month-orange-silver-and-purple",
                "No word in the English language rhymes with month, orange, silver, and purple.",
                "Word & Language"
              ),
              new FactModel(
                90,
                "On average, half of all false teeth have some form of radioactivity.",
                "On-average-half-of-all-false-teeth-have-some-form-of-radioactivity",
                "On average, half of all false teeth have some form of radioactivity.",
                "Science & Technology"
              ),
              new FactModel(
                91,
                "No word in the English language rhymes with month, orange, silver or purple.",
                "No-word-in-the-English-language-rhymes-with-month-orange-silver-or-purple",
                "No word in the English language rhymes with month, orange, silver or purple.",
                "Word & Language"
              ),
              new FactModel(
                92,
                "Sloths take two weeks to digest their food.",
                "Sloths-take-two-weeks-to-digest-their-food",
                "Sloths take two weeks to digest their food.",
                "Animal"
              ),
              new FactModel(
                93,
                "Average life span of a major league baseball: 7 pitches.",
                "Average-life-span-of-a-major-league-baseball-7-pitches",
                "Average life span of a major league baseball: 7 pitches.",
                "Misc"
              ),
              new FactModel(
                94,
                "Intelligent people have more zinc and copper in their hair.",
                "Intelligent-people-have-more-zinc-and-copper-in-their-hair",
                "Intelligent people have more zinc and copper in their hair.",
                "Science & Technology"
              ),
              new FactModel(
                95,
                "Women blink nearly twice as much as men.",
                "Women-blink-nearly-twice-as-much-as-men",
                "Women blink nearly twice as much as men.",
                "Human"
              ),
              new FactModel(
                96,
                "It’s against the law to have a pet dog in Iceland.",
                "It’s-against-the-law-to-have-a-pet-dog-in-Iceland",
                "It’s against the law to have a pet dog in Iceland.",
                "Misc"
              ),
              new FactModel(
                97,
                "A tiny amount of liquor on a scorpion will make it instantly go mad and sting",
                "A-tiny-amount-of-liquor-on-a-scorpion-will-make-it-instantly-go-mad-and-sting",
                "A tiny amount of liquor on a scorpion will make it instantly go mad and sting itself to death.",
                "Animal"
              ),
              new FactModel(
                98,
                "The male praying mantis cannot copulate while its head is attached to its bod",
                "The-male-praying-mantis-cannot-copulate-while-its-head-is-attached-to-its-bod",
                "The male praying mantis cannot copulate while its head is attached to its body. The female initiates sex by ripping the male's head off.",
                "Animal"
              ),
              new FactModel(
                99,
                "Only 1 in 2,000,000,000 will live to be 116 or older.",
                "Only-1-in-2-000-000-000-will-live-to-be-116-or-older",
                "Only 1 in 2,000,000,000 will live to be 116 or older.",
                "Human"
              ),
              new FactModel(
                100,
                "There are 293 ways to make change for a dollar.",
                "There-are-293-ways-to-make-change-for-a-dollar",
                "There are 293 ways to make change for a dollar.",
                "Misc"
              ),
              new FactModel(
                101,
                "Nearly 80% of all animals on earth have six legs.",
                "Nearly-80-of-all-animals-on-earth-have-six-legs",
                " Nearly 80% of all animals on earth have six legs.",
                "Animal"
              ),
              new FactModel(
                102,
                "North American oysters do not make pearls of any value.",
                "North-American-oysters-do-not-make-pearls-of-any-value",
                "North American oysters do not make pearls of any value.",
                "Misc"
              ),
              new FactModel(
                103,
                "Snails can sleep for 3 years without eating",
                "Snails-can-sleep-for-3-years-without-eating",
                "Snails can sleep for 3 years without eating",
                "Animal"
              ),
              new FactModel(
                104,
                "The cruise liner Queen Elizabeth II, moves only six inches for each gallon of",
                "The-cruise-liner-Queen-Elizabeth-II-moves-only-six-inches-for-each-gallon-of",
                "The cruise liner Queen Elizabeth II, moves only six inches for each gallon of fuel that it burns.",
                "Misc"
              ),
              new FactModel(
                105,
                "Your stomach has to produce a new layer of mucus every two weeks otherwise it",
                "Your-stomach-has-to-produce-a-new-layer-of-mucus-every-two-weeks-otherwise-it",
                "Your stomach has to produce a new layer of mucus every two weeks otherwise it will digest itself",
                "Human"
              ),
              new FactModel(
                106,
                "The human heart creates enough pressure when it pumps out to the body to squi",
                "The-human-heart-creates-enough-pressure-when-it-pumps-out-to-the-body-to-squi",
                "The human heart creates enough pressure when it pumps out to the body to squirt blood 30 feet.",
                "Human"
              ),
              new FactModel(
                107,
                "A giraffe can go without water longer than a camel.",
                "A-giraffe-can-go-without-water-longer-than-a-camel",
                "A giraffe can go without water longer than a camel.",
                "Animal"
              ),
              new FactModel(
                108,
                "James Doohan, who played Lt. Commander Montgomery Scott on Star Trek, was mis",
                "James-Doohan-who-played-Lt-Commander-Montgomery-Scott-on-Star-Trek-was-mis",
                "James Doohan, who played Lt. Commander Montgomery Scott on Star Trek, was missing the entire middle finger of his right hand.",
                "Entertainment"
              ),
              new FactModel(
                109,
                "The strongest muscle in the body is the tongue.",
                "The-strongest-muscle-in-the-body-is-the-tongue",
                "The strongest muscle in the body is the tongue.",
                "Human"
              ),
              new FactModel(
                110,
                "The porpoise is second to man as the most intelligent animal on the planet.",
                "The-porpoise-is-second-to-man-as-the-most-intelligent-animal-on-the-planet",
                "The porpoise is second to man as the most intelligent animal on the planet.",
                "Animal"
              ),
              new FactModel(
                111,
                "Every person has a unique tongue print.",
                "Every-person-has-a-unique-tongue-print",
                "Every person has a unique tongue print.",
                "Human"
              ),
              new FactModel(
                112,
                "First novel ever written on a typewriter: Tom Sawyer",
                "First-novel-ever-written-on-a-typewriter-Tom-Sawyer",
                "First novel ever written on a typewriter: Tom Sawyer",
                "Entertainment"
              ),
              new FactModel(
                113,
                "Horatio Nelson, one of England’s most illustrious admirals was throughout his",
                "Horatio-Nelson-one-of-England’s-most-illustrious-admirals-was-throughout-his",
                "Horatio Nelson, one of England’s most illustrious admirals was throughout his life, never able to find a cure for his sea-sickness.",
                "Misc"
              ),
              new FactModel(
                114,
                "'I am' is the shortest complete sentence in the English language.",
                "I-am-is-the-shortest-complete-sentence-in-the-English-language",
                "'I am' is the shortest complete sentence in the English language.",
                "Word & Language"
              ),
              new FactModel(
                115,
                "Right handed people live, on average, nine years longer than left-handed peop",
                "Right-handed-people-live-on-average-nine-years-longer-than-left-handed-peop",
                "Right handed people live, on average, nine years longer than left-handed people",
                "Human"
              ),
              new FactModel(
                116,
                "The electric chair was invented by a dentist.",
                "The-electric-chair-was-invented-by-a-dentist",
                "The electric chair was invented by a dentist.",
                "Misc"
              ),
              new FactModel(
                117,
                "There is approximately one chicken for every human being in the world.",
                "There-is-approximately-one-chicken-for-every-human-being-in-the-world",
                "There is approximately one chicken for every human being in the world.",
                "Animal"
              ),
              new FactModel(
                118,
                "Only one person in two billion will live to be 116 or older.",
                "Only-one-person-in-two-billion-will-live-to-be-116-or-older",
                "Only one person in two billion will live to be 116 or older.",
                "Human"
              ),
              new FactModel(
                119,
                "The sentence 'The quick brown fox jumps over the lazy dog.' uses every letter",
                "The-sentence-The-quick-brown-fox-jumps-over-the-lazy-dog--uses-every-letter",
                "The sentence 'The quick brown fox jumps over the lazy dog.' uses every letter in the alphabet. (Developed by Western Union to Test telex/two communications)",
                "Word & Language"
              ),
              new FactModel(
                120,
                "The number of possible ways of playing the first four moves per side in a gam",
                "The-number-of-possible-ways-of-playing-the-first-four-moves-per-side-in-a-gam",
                "The number of possible ways of playing the first four moves per side in a game of chess is 318,979,564,000.",
                "Misc"
              ),
              new FactModel(
                121,
                "On average a hedgehog’s heart beats 300 times a minute.",
                "On-average-a-hedgehog’s-heart-beats-300-times-a-minute",
                "On average a hedgehog’s heart beats 300 times a minute.",
                "Animal"
              ),
              new FactModel(
                122,
                "The average person falls asleep in seven minutes.",
                "The-average-person-falls-asleep-in-seven-minutes",
                "The average person falls asleep in seven minutes.",
                "Human"
              ),
              new FactModel(
                123,
                "Maine is the only state whose name is just one syllable.",
                "Maine-is-the-only-state-whose-name-is-just-one-syllable",
                "Maine is the only state whose name is just one syllable.",
                "Misc"
              ),
              new FactModel(
                124,
                "A Saudi Arabian woman can get a divorce if her husband doesn't give her coffe",
                "A-Saudi-Arabian-woman-can-get-a-divorce-if-her-husband-doesn-t-give-her-coffe",
                "A Saudi Arabian woman can get a divorce if her husband doesn't give her coffee.",
                "Human"
              ),
              new FactModel(
                125,
                "The plastic things on the end of shoelaces are called aglets.",
                "The-plastic-things-on-the-end-of-shoelaces-are-called-aglets",
                "The plastic things on the end of shoelaces are called aglets.",
                "Misc"
              ),
              new FactModel(
                126,
                "Human birth control pills work on gorillas.",
                "Human-birth-control-pills-work-on-gorillas",
                "Human birth control pills work on gorillas.",
                "Misc"
              ),
              new FactModel(
                127,
                "Table tennis balls have been known to travel off the paddle at speeds up to 1",
                "Table-tennis-balls-have-been-known-to-travel-off-the-paddle-at-speeds-up-to-1",
                "Table tennis balls have been known to travel off the paddle at speeds up to 160 km/hr.",
                "Misc"
              ),
              new FactModel(
                128,
                "Figlet, an ASCII font converter program, stands for Frank, Ian and Glenn's LE",
                "Figlet-an-ASCII-font-converter-program-stands-for-Frank-Ian-and-Glenn-s-LE",
                "Figlet, an ASCII font converter program, stands for Frank, Ian and Glenn's LETters.",
                "Science & Technology"
              ),
              new FactModel(
                129,
                "Thirty-five percent of the people who use personal ads for dating are already",
                "Thirty-five-percent-of-the-people-who-use-personal-ads-for-dating-are-already",
                "Thirty-five percent of the people who use personal ads for dating are already married.",
                "Human"
              ),
              new FactModel(
                130,
                "315 entries in Webster's 1996 Dictionary were misspelled.",
                "315-entries-in-Webster-s-1996-Dictionary-were-misspelled",
                "315 entries in Webster's 1996 Dictionary were misspelled.",
                "Word & Language"
              ),
              new FactModel(
                131,
                "The 'dot' over the letter 'i' is called a tittle.",
                "The-dot-over-the-letter-i-is-called-a-tittle",
                "The 'dot' over the letter 'i' is called a tittle.",
                "Word & Language"
              ),
              new FactModel(
                132,
                "A shark can detect one part of blood in 100 million parts of water.",
                "A-shark-can-detect-one-part-of-blood-in-100-million-parts-of-water",
                "A shark can detect one part of blood in 100 million parts of water.",
                "Animal"
              ),
              new FactModel(
                133,
                "Warren Beatty and Shirley MacLaine are brother and sister.",
                "Warren-Beatty-and-Shirley-MacLaine-are-brother-and-sister",
                "Warren Beatty and Shirley MacLaine are brother and sister.",
                "Entertainment"
              ),
              new FactModel(
                134,
                "The only 15 letter word that can be spelled without repeating a letter is 'un",
                "The-only-15-letter-word-that-can-be-spelled-without-repeating-a-letter-is-un",
                "The only 15 letter word that can be spelled without repeating a letter is 'uncopyrightable'.",
                "Word & Language"
              ),
              new FactModel(
                135,
                "The lifespan of a squirrel is about nine years.",
                "The-lifespan-of-a-squirrel-is-about-nine-years",
                "The lifespan of a squirrel is about nine years.",
                "Animal"
              ),
              new FactModel(
                136,
                "A cockroach will live nine days without its head before it starves to death!",
                "A-cockroach-will-live-nine-days-without-its-head-before-it-starves-to-death",
                "A cockroach will live nine days without its head before it starves to death!",
                "Animal"
              ),
              new FactModel(
                137,
                "Beetles taste like apples, wasps like pine nuts, and worms like fried bacon.",
                "Beetles-taste-like-apples-wasps-like-pine-nuts-and-worms-like-fried-bacon",
                "Beetles taste like apples, wasps like pine nuts, and worms like fried bacon.",
                "Animal"
              ),
              new FactModel(
                138,
                "Chewing gum while peeling onions will keep you from crying!",
                "Chewing-gum-while-peeling-onions-will-keep-you-from-crying",
                "Chewing gum while peeling onions will keep you from crying!",
                "Misc"
              ),
              new FactModel(
                139,
                "The citrus soda 7-UP was created in 1929, '7' was selected after the original",
                "The-citrus-soda-7-UP-was-created-in-1929--7-was-selected-after-the-original",
                "The citrus soda 7-UP was created in 1929, '7' was selected after the original 7-ounce containers and 'UP' for the direction of the bubbles.",
                "Misc"
              ),
              new FactModel(
                140,
                "Hummingbirds are the only animal that can fly backwards.",
                "Hummingbirds-are-the-only-animal-that-can-fly-backwards",
                "Hummingbirds are the only animal that can fly backwards.",
                "Misc"
              ),
              new FactModel(
                141,
                "Because of the rotation of the earth, an object can be thrown farther if it i",
                "Because-of-the-rotation-of-the-earth-an-object-can-be-thrown-farther-if-it-i",
                "Because of the rotation of the earth, an object can be thrown farther if it is thrown west.",
                "Science & Technology"
              ),
              new FactModel(
                142,
                "Susan Lucci is the daughter of Phyllis Diller.",
                "Susan-Lucci-is-the-daughter-of-Phyllis-Diller",
                "Susan Lucci is the daughter of Phyllis Diller.",
                "Misc"
              ),
              new FactModel(
                143,
                "The six official languages of the United Nations are: English, French, Arabic",
                "The-six-official-languages-of-the-United-Nations-are-English-French-Arabic",
                "The six official languages of the United Nations are: English, French, Arabic, Chinese, Russian and Spanish.",
                "Word & Language"
              ),
              new FactModel(
                144,
                "A person can live without food for about a month, but only about a week witho",
                "A-person-can-live-without-food-for-about-a-month-but-only-about-a-week-witho",
                "A person can live without food for about a month, but only about a week without water.",
                "Human"
              ),
              new FactModel(
                145,
                "Like fingerprints, everyone's tongue print is different.",
                "Like-fingerprints-everyone-s-tongue-print-is-different",
                "Like fingerprints, everyone's tongue print is different.",
                "Human"
              ),
              new FactModel(
                146,
                "Cost of raising a medium-sized dog to the age of 11: £4000",
                "Cost-of-raising-a-medium-sized-dog-to-the-age-of-11-£4000",
                "Cost of raising a medium-sized dog to the age of 11: £4000",
                "Misc"
              ),
              new FactModel(
                147,
                "The 'pound' key on your keyboard (#) is called an octotroph.",
                "The-pound-key-on-your-keyboard---is-called-an-octotroph",
                "The 'pound' key on your keyboard (#) is called an octotroph.",
                "Science & Technology"
              ),
              new FactModel(
                148,
                "If you yelled for 8 years, 7 months and 6 days you would have produced enough",
                "If-you-yelled-for-8-years-7-months-and-6-days-you-would-have-produced-enough",
                "If you yelled for 8 years, 7 months and 6 days you would have produced enough sound energy to heat one cup of coffee.",
                "Human"
              ),
              new FactModel(
                149,
                "A male emperor moth can smell a female emperor moth up to 7 miles away.",
                "A-male-emperor-moth-can-smell-a-female-emperor-moth-up-to-7-miles-away",
                "A male emperor moth can smell a female emperor moth up to 7 miles away.",
                "Animal"
              ),
              new FactModel(
                150,
                "There are an average of 178 sesame seeds on a McDonald's Big Mac bun.",
                "There-are-an-average-of-178-sesame-seeds-on-a-McDonald-s-Big-Mac-bun",
                "There are an average of 178 sesame seeds on a McDonald's Big Mac bun.",
                "Misc"
              ),
              new FactModel(
                151,
                "The Hawaiian alphabet has 12 letters.",
                "The-Hawaiian-alphabet-has-12-letters",
                "The Hawaiian alphabet has 12 letters.",
                "Word & Language"
              ),
              new FactModel(
                152,
                "Only one satellite has been ever been destroyed by a meteor: the European Spa",
                "Only-one-satellite-has-been-ever-been-destroyed-by-a-meteor-the-European-Spa",
                "Only one satellite has been ever been destroyed by a meteor: the European Space Agency's Olympus in 1993.",
                "Science & Technology"
              ),
              new FactModel(
                153,
                "A 'jiffy' is an actual unit of time: 1/100th of a second.",
                "A-jiffy-is-an-actual-unit-of-time-1-100th-of-a-second",
                "A 'jiffy' is an actual unit of time: 1/100th of a second.",
                "Misc"
              ),
              new FactModel(
                154,
                "Polar bears are left-handed.",
                "Polar-bears-are-left-handed",
                "Polar bears are left-handed.",
                "Animal"
              ),
              new FactModel(
                155,
                "Jellyfish like salt water. A rainy season often reduces the jellyfish populat",
                "Jellyfish-like-salt-water-A-rainy-season-often-reduces-the-jellyfish-populat",
                "Jellyfish like salt water. A rainy season often reduces the jellyfish population by putting more fresh water into normally salty waters where they live.",
                "Animal"
              ),
              new FactModel(
                156,
                "More people are killed annually by donkeys than airplane crashes.",
                "More-people-are-killed-annually-by-donkeys-than-airplane-crashes",
                "More people are killed annually by donkeys than airplane crashes.",
                "Misc"
              ),
              new FactModel(
                157,
                "The only domestic animal not mentioned in the Bible is the cat.",
                "The-only-domestic-animal-not-mentioned-in-the-Bible-is-the-cat",
                "The only domestic animal not mentioned in the Bible is the cat.",
                "Animal"
              ),
              new FactModel(
                158,
                "Cephalacaudal recapitulation is the reason our extremities develop Faster tha",
                "Cephalacaudal-recapitulation-is-the-reason-our-extremities-develop-Faster-tha",
                "Cephalacaudal recapitulation is the reason our extremities develop Faster than the rest of us.",
                "Misc"
              ),
              new FactModel(
                159,
                "There are more than fifty different kinds of kangaroos.",
                "There-are-more-than-fifty-different-kinds-of-kangaroos",
                "There are more than fifty different kinds of kangaroos.",
                "Animal"
              ),
              new FactModel(
                160,
                "Stewardesses' is the longest word that is typed with only the left hand.",
                "Stewardesses-is-the-longest-word-that-is-typed-with-only-the-left-hand",
                "Stewardesses' is the longest word that is typed with only the left hand.",
                "Word & Language"
              ),
              new FactModel(
                161,
                "Queen Elizabeth I regarded herself as a paragon of cleanliness. She declared",
                "Queen-Elizabeth-I-regarded-herself-as-a-paragon-of-cleanliness-She-declared",
                "Queen Elizabeth I regarded herself as a paragon of cleanliness. She declared that she bathed once every three months, whether she needed it or not",
                "Misc"
              ),
              new FactModel(
                162,
                "Seals used for their fur get extremely sick when taken aboard ships.",
                "Seals-used-for-their-fur-get-extremely-sick-when-taken-aboard-ships",
                "Seals used for their fur get extremely sick when taken aboard ships.",
                "Animal"
              ),
              new FactModel(
                163,
                "Bees have 5 eyes. There are 3 small eyes on the top of a bee's head and 2 lar",
                "Bees-have-5-eyes-There-are-3-small-eyes-on-the-top-of-a-bee-s-head-and-2-lar",
                "Bees have 5 eyes. There are 3 small eyes on the top of a bee's head and 2 larger ones in front.",
                "Animal"
              ),
              new FactModel(
                164,
                "The duckbill platypus can store as many as six hundred worms in the pouches o",
                "The-duckbill-platypus-can-store-as-many-as-six-hundred-worms-in-the-pouches-o",
                "The duckbill platypus can store as many as six hundred worms in the pouches of its cheeks.",
                "Animal"
              ),
              new FactModel(
                165,
                "Ninety percent of all species that have become extinct have been birds.",
                "Ninety-percent-of-all-species-that-have-become-extinct-have-been-birds",
                "Ninety percent of all species that have become extinct have been birds.",
                "Animal"
              ),
              new FactModel(
                166,
                "Some lions mate over 50 times a day.",
                "Some-lions-mate-over-50-times-a-day",
                "Some lions mate over 50 times a day.",
                "Animal"
              ),
              new FactModel(
                167,
                "You’re born with 300 bones, but by the time you become an adult, you only hav",
                "You’re-born-with-300-bones-but-by-the-time-you-become-an-adult-you-only-hav",
                "You’re born with 300 bones, but by the time you become an adult, you only have 206.",
                "Human"
              ),
              new FactModel(
                168,
                "More people are killed annually by donkeys than die in aircrashes.",
                "More-people-are-killed-annually-by-donkeys-than-die-in-aircrashes",
                "More people are killed annually by donkeys than die in aircrashes.",
                "Animal"
              ),
              new FactModel(
                169,
                "Every year about 98% of atoms in your body are replaced.",
                "Every-year-about-98-of-atoms-in-your-body-are-replaced",
                "Every year about 98% of atoms in your body are replaced.",
                "Human"
              ),
              new FactModel(
                170,
                "The average person laughs 10 times a day!",
                "The-average-person-laughs-10-times-a-day",
                "The average person laughs 10 times a day!",
                "Human"
              ),
              new FactModel(
                171,
                "The average person falls asleep in seven minutes.",
                "The-average-person-falls-asleep-in-seven-minutes",
                "The average person falls asleep in seven minutes.",
                "Human"
              ),
              new FactModel(
                172,
                "Wearing headphones for just an hour will increase the bacteria in your ear by",
                "Wearing-headphones-for-just-an-hour-will-increase-the-bacteria-in-your-ear-by",
                "Wearing headphones for just an hour will increase the bacteria in your ear by 700 times.",
                "Human"
              ),
              new FactModel(
                173,
                "The present population of 5 billion plus people of the world is predicted to",
                "The-present-population-of-5-billion-plus-people-of-the-world-is-predicted-to",
                "The present population of 5 billion plus people of the world is predicted to become 15 billion by 2080.",
                "Misc"
              ),
              new FactModel(
                174,
                "A group of twelve or more cows is called a flink.",
                "A-group-of-twelve-or-more-cows-is-called-a-flink",
                "A group of twelve or more cows is called a flink.",
                "Animal"
              ),
              new FactModel(
                175,
                "Rubber bands last longer when refrigerated.",
                "Rubber-bands-last-longer-when-refrigerated",
                "Rubber bands last longer when refrigerated.",
                "Misc"
              ),
              new FactModel(
                176,
                "Every human spent about half an hour as a single cell.",
                "Every-human-spent-about-half-an-hour-as-a-single-cell",
                "Every human spent about half an hour as a single cell.",
                "Human"
              ),
              new FactModel(
                177,
                "A duck's quack doesn't echo, and no one knows why.",
                "A-duck-s-quack-doesn-t-echo-and-no-one-knows-why",
                "A duck's quack doesn't echo, and no one knows why.",
                "Animal"
              ),
              new FactModel(
                178,
                "The fingerprints of koala bears are virtually indistinguishable from those of",
                "The-fingerprints-of-koala-bears-are-virtually-indistinguishable-from-those-of",
                "The fingerprints of koala bears are virtually indistinguishable from those of humans, so much so that they could be confused at a crime scene.",
                "Animal"
              ),
              new FactModel(
                179,
                "On average, dogs have better eyesight than humans, although not as colorful.",
                "On-average-dogs-have-better-eyesight-than-humans-although-not-as-colorful",
                "On average, dogs have better eyesight than humans, although not as colorful.",
                "Animal"
              ),
              new FactModel(
                180,
                "If you keep your eyes open by force when you sneeze, you might pop an eyeball",
                "If-you-keep-your-eyes-open-by-force-when-you-sneeze-you-might-pop-an-eyeball",
                "If you keep your eyes open by force when you sneeze, you might pop an eyeball out.",
                "Human"
              ),
              new FactModel(
                181,
                "Butterflies taste with their feet.",
                "Butterflies-taste-with-their-feet",
                "Butterflies taste with their feet.",
                "Animal"
              ),
              new FactModel(
                182,
                "Guinness Book of Records holds the record for being the book most often stole",
                "Guinness-Book-of-Records-holds-the-record-for-being-the-book-most-often-stole",
                "Guinness Book of Records holds the record for being the book most often stolen from Public Libraries.",
                "Misc"
              ),
              new FactModel(
                183,
                "The first couple to be shown in bed together on prime time television were Fr",
                "The-first-couple-to-be-shown-in-bed-together-on-prime-time-television-were-Fr",
                "The first couple to be shown in bed together on prime time television were Fred and Wilma Flintstone.",
                "Entertainment"
              ),
              new FactModel(
                184,
                "There is a city called Rome on every continent.",
                "There-is-a-city-called-Rome-on-every-continent",
                "There is a city called Rome on every continent.",
                "Misc"
              ),
              new FactModel(
                185,
                "Barbie's full name is Barbara Millicent Roberts.",
                "Barbie-s-full-name-is-Barbara-Millicent-Roberts",
                "Barbie's full name is Barbara Millicent Roberts.",
                "Entertainment"
              ),
              new FactModel(
                186,
                "Outside the USA, Ireland is the largest software producing country in the wor",
                "Outside-the-USA-Ireland-is-the-largest-software-producing-country-in-the-wor",
                "Outside the USA, Ireland is the largest software producing country in the world.",
                "Science & Technology"
              ),
              new FactModel(
                187,
                "The 57 on Heinz ketchup bottle represents the varieties of pickle the company",
                "The-57-on-Heinz-ketchup-bottle-represents-the-varieties-of-pickle-the-company",
                "The 57 on Heinz ketchup bottle represents the varieties of pickle the company once had.",
                "Misc"
              ),
              new FactModel(
                188,
                "The skeleton of Jeremy Bentham is present at all important meetings of the Un",
                "The-skeleton-of-Jeremy-Bentham-is-present-at-all-important-meetings-of-the-Un",
                "The skeleton of Jeremy Bentham is present at all important meetings of the University of London",
                "Misc"
              ),
              new FactModel(
                189,
                "The male gypsy moth can 'smell' the virgin female gypsy moth from 1.8 miles a",
                "The-male-gypsy-moth-can-smell-the-virgin-female-gypsy-moth-from-1-8-miles-a",
                "The male gypsy moth can 'smell' the virgin female gypsy moth from 1.8 miles away (pretty good trick).",
                "Animal"
              ),
              new FactModel(
                190,
                "Mr. Rogers is an ordained minister.",
                "Mr-Rogers-is-an-ordained-minister",
                "Mr. Rogers is an ordained minister.",
                "Misc"
              ),
              new FactModel(
                191,
                "A crocodile can't move its tongue and cannot chew. Its digestive juices are s",
                "A-crocodile-can-t-move-its-tongue-and-cannot-chew-Its-digestive-juices-are-s",
                "A crocodile can't move its tongue and cannot chew. Its digestive juices are so strong that it can digest a steel nail.",
                "Animal"
              ),
              new FactModel(
                192,
                "Earth is the only planet not named after a god.",
                "Earth-is-the-only-planet-not-named-after-a-god",
                "Earth is the only planet not named after a god.",
                "Misc"
              ),
              new FactModel(
                193,
                "All 50 states are listed across the top of the Lincoln Memorial on the back o",
                "All-50-states-are-listed-across-the-top-of-the-Lincoln-Memorial-on-the-back-o",
                "All 50 states are listed across the top of the Lincoln Memorial on the back of the $5 bill.",
                "Misc"
              ),
              new FactModel(
                194,
                "'Stewardesses' is the longest word that is typed with only the left hand.",
                "Stewardesses-is-the-longest-word-that-is-typed-with-only-the-left-hand",
                "'Stewardesses' is the longest word that is typed with only the left hand.",
                "Word & Language"
              ),
              new FactModel(
                195,
                "Owls are the only birds who can see the colour blue.",
                "Owls-are-the-only-birds-who-can-see-the-colour-blue",
                "Owls are the only birds who can see the colour blue.",
                "Animal"
              ),
              new FactModel(
                196,
                "During the chariot scene in 'Ben Hur' a small red car can be seen in the dist",
                "During-the-chariot-scene-in-Ben-Hur-a-small-red-car-can-be-seen-in-the-dist",
                "During the chariot scene in 'Ben Hur' a small red car can be seen in the distance.",
                "Entertainment"
              ),
              new FactModel(
                197,
                "Western Electric successfully brought sound to motion pictures and introduced",
                "Western-Electric-successfully-brought-sound-to-motion-pictures-and-introduced",
                "Western Electric successfully brought sound to motion pictures and introduced systems of mobile communications which culminated in the cellular telephone.",
                "Science & Technology"
              ),
              new FactModel(
                198,
                "The flea can jump 350 times its body length. It's like a human jumping the le",
                "The-flea-can-jump-350-times-its-body-length-It-s-like-a-human-jumping-the-le",
                "The flea can jump 350 times its body length. It's like a human jumping the length of a football field.",
                "Animal"
              ),
              new FactModel(
                199,
                "If you went out into space, you would explode before you suffocated because t",
                "If-you-went-out-into-space-you-would-explode-before-you-suffocated-because-t",
                "If you went out into space, you would explode before you suffocated because there's no air pressure.",
                "Science & Technology"
              ),
              new FactModel(
                200,
                "John Lennon's first girlfriend was named Thelma Pickles.",
                "John-Lennon-s-first-girlfriend-was-named-Thelma-Pickles",
                "John Lennon's first girlfriend was named Thelma Pickles.",
                "Entertainment"
              ),
              new FactModel(
                201,
                "Dolphins sleep with one eye open!",
                "Dolphins-sleep-with-one-eye-open",
                "Dolphins sleep with one eye open!",
                "Animal"
              ),
              new FactModel(
                202,
                "Armadillos are the only animal besides humans that can get leprosy.",
                "Armadillos-are-the-only-animal-besides-humans-that-can-get-leprosy",
                "Armadillos are the only animal besides humans that can get leprosy.",
                "Animal"
              ),
              new FactModel(
                203,
                "Starfish have no brains.",
                "Starfish-have-no-brains",
                "Starfish have no brains.",
                "Animal"
              ),
              new FactModel(
                204,
                "Michael Jordan makes more money from NIKE annually than all of the Nike facto",
                "Michael-Jordan-makes-more-money-from-NIKE-annually-than-all-of-the-Nike-facto",
                "Michael Jordan makes more money from NIKE annually than all of the Nike factory workers in Malaysia combined.",
                "Misc"
              ),
              new FactModel(
                205,
                "Ethernet is a registered trademark of Xerox, Unix is a registered trademark o",
                "Ethernet-is-a-registered-trademark-of-Xerox-Unix-is-a-registered-trademark-o",
                "Ethernet is a registered trademark of Xerox, Unix is a registered trademark of AT&T.",
                "Science & Technology"
              ),
              new FactModel(
                206,
                "If you try to suppress a sneeze, you can rupture a blood vessel in your head",
                "If-you-try-to-suppress-a-sneeze-you-can-rupture-a-blood-vessel-in-your-head",
                "If you try to suppress a sneeze, you can rupture a blood vessel in your head or neck and die.",
                "Human"
              ),
              new FactModel(
                207,
                "Einstein couldn't speak fluently when he was nine. His parents thought he mig",
                "Einstein-couldn-t-speak-fluently-when-he-was-nine-His-parents-thought-he-mig",
                "Einstein couldn't speak fluently when he was nine. His parents thought he might be retarded.",
                "Misc"
              ),
              new FactModel(
                208,
                "Reindeer like to eat bananas.",
                "Reindeer-like-to-eat-bananas",
                "Reindeer like to eat bananas.",
                "Animal"
              ),
              new FactModel(
                209,
                "If you farted consistently for 6 years and 9 months, enough gas is produced t",
                "If-you-farted-consistently-for-6-years-and-9-months-enough-gas-is-produced-t",
                "If you farted consistently for 6 years and 9 months, enough gas is produced to create the energy of an atomic bomb.",
                "Human"
              ),
              new FactModel(
                210,
                "The giant squid has the largest eyes in the world.",
                "The-giant-squid-has-the-largest-eyes-in-the-world",
                "The giant squid has the largest eyes in the world.",
                "Animal"
              ),
              new FactModel(
                211,
                "A crocodile can't stick it's tongue out.",
                "A-crocodile-can-t-stick-it-s-tongue-out",
                "A crocodile can't stick it's tongue out.",
                "Animal"
              ),
              new FactModel(
                212,
                "Bullet proof vests, fire escapes, windshield wipers, and laser printers were",
                "Bullet-proof-vests-fire-escapes-windshield-wipers-and-laser-printers-were",
                "Bullet proof vests, fire escapes, windshield wipers, and laser printers were all invented by women.",
                "Misc"
              ),
              new FactModel(
                213,
                "Men can read smaller print than women; women can hear better than men.",
                "Men-can-read-smaller-print-than-women-women-can-hear-better-than-men",
                "Men can read smaller print than women; women can hear better than men.",
                "Human"
              ),
              new FactModel(
                214,
                "The 3 most valuable brand names on earth: Marlboro, Coca-Cola, and Budweiser",
                "The-3-most-valuable-brand-names-on-earth-Marlboro-Coca-Cola-and-Budweiser",
                "The 3 most valuable brand names on earth: Marlboro, Coca-Cola, and Budweiser, in that order.",
                "Misc"
              ),
              new FactModel(
                215,
                "Hot water is heavier than cold.",
                "Hot-water-is-heavier-than-cold",
                "Hot water is heavier than cold.",
                "Misc"
              ),
              new FactModel(
                216,
                "The name Wendy was made up for the book 'Peter Pan.'",
                "The-name-Wendy-was-made-up-for-the-book-Peter-Pan",
                "The name Wendy was made up for the book 'Peter Pan.'",
                "Entertainment"
              ),
              new FactModel(
                217,
                "A pig's orgasm lasts 30 minutes.",
                "A-pig-s-orgasm-lasts-30-minutes",
                "A pig's orgasm lasts 30 minutes.",
                "Animal"
              ),
              new FactModel(
                218,
                "Winston Churchill was born in a ladies' room during a dance.",
                "Winston-Churchill-was-born-in-a-ladies-room-during-a-dance",
                "Winston Churchill was born in a ladies' room during a dance.",
                "Misc"
              ),
              new FactModel(
                219,
                "Adolf Hitler was a vegetarian, and had only ONE testicle.",
                "Adolf-Hitler-was-a-vegetarian-and-had-only-ONE-testicle",
                "Adolf Hitler was a vegetarian, and had only ONE testicle.",
                "Misc"
              ),
              new FactModel(
                220,
                "A shark is the only fish that can blink with both eyes.",
                "A-shark-is-the-only-fish-that-can-blink-with-both-eyes",
                "A shark is the only fish that can blink with both eyes.",
                "Animal"
              ),
              new FactModel(
                221,
                "Guinea pigs and rabbits can't sweat.",
                "Guinea-pigs-and-rabbits-can-t-sweat",
                "Guinea pigs and rabbits can't sweat.",
                "Animal"
              ),
              new FactModel(
                222,
                "Every time you lick a stamp, you're consuming 1/10 of a calorie.",
                "Every-time-you-lick-a-stamp-you-re-consuming-1-10-of-a-calorie",
                "Every time you lick a stamp, you're consuming 1/10 of a calorie.",
                "Human"
              ),
              new FactModel(
                223,
                "Banging your head against a wall uses 150 calories an hour.",
                "Banging-your-head-against-a-wall-uses-150-calories-an-hour",
                "Banging your head against a wall uses 150 calories an hour.",
                "Human"
              ),
              new FactModel(
                224,
                "The catfish has over 27,000 taste buds.",
                "The-catfish-has-over-27-000-taste-buds",
                "The catfish has over 27,000 taste buds.",
                "Animal"
              ),
              new FactModel(
                225,
                "The female lion does ninety percent of the hunting.",
                "The-female-lion-does-ninety-percent-of-the-hunting",
                "The female lion does ninety percent of the hunting.",
                "Animal"
              ),
              new FactModel(
                226,
                "Hershey's Kisses are called that because the machine that makes them looks li",
                "Hershey-s-Kisses-are-called-that-because-the-machine-that-makes-them-looks-li",
                "Hershey's Kisses are called that because the machine that makes them looks like it's kissing the conveyor belt.",
                "Misc"
              ),
              new FactModel(
                227,
                "The 3 most valuable brand names on earth: Marlboro, Coca-Cola, and Budweiser",
                "The-3-most-valuable-brand-names-on-earth-Marlboro-Coca-Cola-and-Budweiser",
                "The 3 most valuable brand names on earth: Marlboro, Coca-Cola, and Budweiser, in that order.",
                "Misc"
              ),
              new FactModel(
                228,
                "In the course of an average lifetime you will, while sleeping, eat 70 assorte",
                "In-the-course-of-an-average-lifetime-you-will-while-sleeping-eat-70-assorte",
                "In the course of an average lifetime you will, while sleeping, eat 70 assorted insects and 10 spiders.",
                "Misc"
              ),
              new FactModel(
                229,
                "111,111,111 x 111,111,111 = 12,345,678,987,654,321",
                "111-111-111-x-111-111-111-=-12-345-678-987-654-321",
                "111,111,111 x 111,111,111 = 12,345,678,987,654,321",
                "Misc"
              ),
              new FactModel(
                230,
                "Porcupines float in water.",
                "Porcupines-float-in-water",
                "Porcupines float in water.",
                "Animal"
              ),
              new FactModel(
                231,
                "Pound for pound, hamburgers cost more than new cars.",
                "Pound-for-pound-hamburgers-cost-more-than-new-cars",
                "Pound for pound, hamburgers cost more than new cars.",
                "Misc"
              ),
              new FactModel(
                232,
                "The airplane Buddy Holly died in was the 'American Pie.' (Thus the name of th",
                "The-airplane-Buddy-Holly-died-in-was-the-American-Pie--Thus-the-name-of-th",
                "The airplane Buddy Holly died in was the 'American Pie.' (Thus the name of the Don McLean song.)",
                "Entertainment"
              ),
              new FactModel(
                233,
                "The original story from 'Tales of 1001 Arabian Nights' begins, 'Aladdin was a",
                "The-original-story-from-Tales-of-1001-Arabian-Nights-begins--Aladdin-was-a",
                "The original story from 'Tales of 1001 Arabian Nights' begins, 'Aladdin was a little Chinese boy.'",
                "Entertainment"
              ),
              new FactModel(
                234,
                "It is physically impossible for pigs to look up into the sky.",
                "It-is-physically-impossible-for-pigs-to-look-up-into-the-sky",
                "It is physically impossible for pigs to look up into the sky.",
                "Animal"
              ),
              new FactModel(
                235,
                "The mask used by Michael Myers in the original film 'Halloween' was actually",
                "The-mask-used-by-Michael-Myers-in-the-original-film-Halloween-was-actually",
                "The mask used by Michael Myers in the original film 'Halloween' was actually a Captain Kirk mask painted white.",
                "Entertainment"
              ),
              new FactModel(
                236,
                "Gorillas sleep as much as fourteen hours per day.",
                "Gorillas-sleep-as-much-as-fourteen-hours-per-day",
                "Gorillas sleep as much as fourteen hours per day.",
                "Animal"
              ),
              new FactModel(
                237,
                "Emus and kangaroos cannot walk backwards, and are on the Australian coat of a",
                "Emus-and-kangaroos-cannot-walk-backwards-and-are-on-the-Australian-coat-of-a",
                "Emus and kangaroos cannot walk backwards, and are on the Australian coat of arms for that reason.",
                "Animal"
              ),
              new FactModel(
                238,
                "On December 23, 1947, Bell Telephone Laboratories in Murray Hill, N.J., held",
                "On-December-23-1947-Bell-Telephone-Laboratories-in-Murray-Hill-N-J--held",
                "On December 23, 1947, Bell Telephone Laboratories in Murray Hill, N.J., held a secret demonstration of the transistor which marked the foundation of modern electronics.",
                "Science & Technology"
              ),
              new FactModel(
                239,
                "Plutonium - first weighed on August 20th, 1942, by University of Chicago scie",
                "Plutonium--first-weighed-on-August-20th-1942-by-University-of-Chicago-scie",
                "Plutonium - first weighed on August 20th, 1942, by University of Chicago scientists Glenn Seaborg and his colleagues - was the first man-made element.",
                "Science & Technology"
              ),
              new FactModel(
                240,
                "What is called a 'French kiss' in the English speaking world is known as an '",
                "What-is-called-a-French-kiss-in-the-English-speaking-world-is-known-as-an",
                "What is called a 'French kiss' in the English speaking world is known as an 'English kiss' in France.",
                "Word & Language"
              ),
              new FactModel(
                241,
                "Some worms will eat themselves if they can’t find any food!",
                "Some-worms-will-eat-themselves-if-they-can’t-find-any-food",
                "Some worms will eat themselves if they can’t find any food!",
                "Misc"
              ),
              new FactModel(
                242,
                "In every episode of Seinfeld there is a Superman somewhere.",
                "In-every-episode-of-Seinfeld-there-is-a-Superman-somewhere",
                "In every episode of Seinfeld there is a Superman somewhere.",
                "Entertainment"
              ),
              new FactModel(
                243,
                "23% of all photocopier faults worldwide are caused by people sitting on them",
                "23-of-all-photocopier-faults-worldwide-are-caused-by-people-sitting-on-them",
                "23% of all photocopier faults worldwide are caused by people sitting on them and photocopying their butts.",
                "Misc"
              ),
              new FactModel(
                244,
                "Al Capone's business card said he was a used furniture dealer.",
                "Al-Capone-s-business-card-said-he-was-a-used-furniture-dealer",
                "Al Capone's business card said he was a used furniture dealer.",
                "Misc"
              ),
              new FactModel(
                245,
                "Women manage the money and pay the bills in  75% of all Americans households.",
                "Women-manage-the-money-and-pay-the-bills-in -75-of-all-Americans-households",
                "Women manage the money and pay the bills in  75% of all Americans households.",
                "Misc"
              ),
              new FactModel(
                246,
                "Certain frogs can be frozen solid, then thawed, and survive.",
                "Certain-frogs-can-be-frozen-solid-then-thawed-and-survive",
                "Certain frogs can be frozen solid, then thawed, and survive.",
                "Animal"
              ),
              new FactModel(
                247,
                "If you spell out consecutive numbers, you have to go up to one thousand until",
                "If-you-spell-out-consecutive-numbers-you-have-to-go-up-to-one-thousand-until",
                "If you spell out consecutive numbers, you have to go up to one thousand until you would find the letter 'a'",
                "Word & Language"
              ),
              new FactModel(
                248,
                "There are no clocks in Las Vegas gambling casinos.",
                "There-are-no-clocks-in-Las-Vegas-gambling-casinos",
                "There are no clocks in Las Vegas gambling casinos.",
                "Misc"
              ),
              new FactModel(
                249,
                "It is impossible to sneeze with your eyes open",
                "It-is-impossible-to-sneeze-with-your-eyes-open",
                "It is impossible to sneeze with your eyes open",
                "Human"
              ),
              new FactModel(
                250,
                "Skunks can accurately spray their smelly fluid as far as ten feet.",
                "Skunks-can-accurately-spray-their-smelly-fluid-as-far-as-ten-feet",
                "Skunks can accurately spray their smelly fluid as far as ten feet.",
                "Animal"
              ),
              new FactModel(
                251,
                "Slugs have 4 noses.",
                "Slugs-have-4-noses",
                "Slugs have 4 noses.",
                "Animal"
              ),
              new FactModel(
                252,
                "Money isn't made out of paper; it's made out of cotton.",
                "Money-isn-t-made-out-of-paper-it-s-made-out-of-cotton",
                "Money isn't made out of paper; it's made out of cotton.",
                "Misc"
              ),
              new FactModel(
                253,
                "Daylight Saving Time is not observed in most of the state of Arizona and part",
                "Daylight-Saving-Time-is-not-observed-in-most-of-the-state-of-Arizona-and-part",
                "Daylight Saving Time is not observed in most of the state of Arizona and parts of Indiana.",
                "Misc"
              ),
              new FactModel(
                254,
                "Orcas (killer whales) kill sharks by torpedoing up into to shark's stomach fr",
                "Orcas-killer-whales-kill-sharks-by-torpedoing-up-into-to-shark-s-stomach-fr",
                "Orcas (killer whales) kill sharks by torpedoing up into to shark's stomach from underneath, causing the shark to explode.",
                "Animal"
              ),
              new FactModel(
                255,
                "In most advertisements, including newspapers, the time displayed on a watch i",
                "In-most-advertisements-including-newspapers-the-time-displayed-on-a-watch-i",
                "In most advertisements, including newspapers, the time displayed on a watch is 10:10.",
                "Misc"
              ),
              new FactModel(
                256,
                "Humans and dolphins are the only species that have sex for pleasure.",
                "Humans-and-dolphins-are-the-only-species-that-have-sex-for-pleasure",
                "Humans and dolphins are the only species that have sex for pleasure.",
                "Animal"
              ),
              new FactModel(
                257,
                "A raisin dropped in a glass of fresh champagne will bounce up and down contin",
                "A-raisin-dropped-in-a-glass-of-fresh-champagne-will-bounce-up-and-down-contin",
                "A raisin dropped in a glass of fresh champagne will bounce up and down continuously from the bottom of the glass to the top.",
                "Misc"
              ),
              new FactModel(
                258,
                "A goldfish has a memory span of three seconds.",
                "A-goldfish-has-a-memory-span-of-three-seconds",
                "A goldfish has a memory span of three seconds.",
                "Animal"
              ),
              new FactModel(
                259,
                "One quarter of the bones in your body are in your feet.",
                "One-quarter-of-the-bones-in-your-body-are-in-your-feet",
                "One quarter of the bones in your body are in your feet.",
                "Human"
              ),
              new FactModel(
                260,
                "The human heart! creates enough pressure when it pumps out to the body to squ",
                "The-human-heart-creates-enough-pressure-when-it-pumps-out-to-the-body-to-squ",
                "The human heart! creates enough pressure when it pumps out to the body to squirt blood 30 feet.",
                "Human"
              ),
              new FactModel(
                261,
                "Honey is the only food that does not spoil. Honey found in the tombs of Egypt",
                "Honey-is-the-only-food-that-does-not-spoil-Honey-found-in-the-tombs-of-Egypt",
                "Honey is the only food that does not spoil. Honey found in the tombs of Egyptian pharaohs has been tasted by archaeologists and found edible.",
                "Misc"
              ),
              new FactModel(
                262,
                "Two-thirds of the world's eggplant is grown in New Jersey.",
                "Two-thirds-of-the-world-s-eggplant-is-grown-in-New-Jersey",
                "Two-thirds of the world's eggplant is grown in New Jersey.",
                "Misc"
              ),
              new FactModel(
                263,
                "The first fossilized specimen of Australopithecus afarenisis was named Lucy a",
                "The-first-fossilized-specimen-of-Australopithecus-afarenisis-was-named-Lucy-a",
                "The first fossilized specimen of Australopithecus afarenisis was named Lucy after the paleontologists' favorite song 'Lucy in the Sky with Diamonds,' by the Beatles.",
                "Misc"
              ),
              new FactModel(
                264,
                "Almonds are members of the peach family.",
                "Almonds-are-members-of-the-peach-family",
                "Almonds are members of the peach family.",
                "Misc"
              ),
              new FactModel(
                265,
                "A pregnant goldfish is called a twit.",
                "A-pregnant-goldfish-is-called-a-twit",
                "A pregnant goldfish is called a twit.",
                "Animal"
              ),
              new FactModel(
                266,
                "Coca Cola was originally green.",
                "Coca-Cola-was-originally-green",
                "Coca Cola was originally green.",
                "Misc"
              ),
              new FactModel(
                267,
                "Deer can't eat hay.",
                "Deer-can-t-eat-hay",
                "Deer can't eat hay.",
                "Animal"
              ),
              new FactModel(
                268,
                "Ketchup was sold in the 1830s as medicine",
                "Ketchup-was-sold-in-the-1830s-as-medicine",
                "Ketchup was sold in the 1830s as medicine",
                "Misc"
              ),
              new FactModel(
                269,
                "Uranus' orbital axis is tilted at 90 degrees.",
                "Uranus-orbital-axis-is-tilted-at-90-degrees",
                "Uranus' orbital axis is tilted at 90 degrees.",
                "Science & Technology"
              ),
              new FactModel(
                270,
                "If the amount of water in your body is reduced by just 1%, you'll feel thirst",
                "If-the-amount-of-water-in-your-body-is-reduced-by-just-1--you-ll-feel-thirst",
                "If the amount of water in your body is reduced by just 1%, you'll feel thirsty.",
                "Human"
              ),
              new FactModel(
                271,
                "'Almost' is the longest word in the English language with all the letters in",
                "Almost-is-the-longest-word-in-the-English-language-with-all-the-letters-in",
                "'Almost' is the longest word in the English language with all the letters in alphabetical order.",
                "Word & Language"
              ),
              new FactModel(
                272,
                "At a jet plane's speed of 1,000 km (620mi) per hour, the length of the plane",
                "At-a-jet-plane-s-speed-of-1-000-km-620mi-per-hour-the-length-of-the-plane",
                "At a jet plane's speed of 1,000 km (620mi) per hour, the length of the plane becomes one atom shorter than its original length.",
                "Science & Technology"
              ),
              new FactModel(
                273,
                "The longest recorded flight of a chicken is thirteen seconds.",
                "The-longest-recorded-flight-of-a-chicken-is-thirteen-seconds",
                "The longest recorded flight of a chicken is thirteen seconds.",
                "Animal"
              ),
              new FactModel(
                274,
                "It has NEVER rained in Calama, a town in the Atacama Desert of Chile.",
                "It-has-NEVER-rained-in-Calama-a-town-in-the-Atacama-Desert-of-Chile",
                "It has NEVER rained in Calama, a town in the Atacama Desert of Chile.",
                "Misc"
              ),
              new FactModel(
                275,
                "People say 'Bless you' when you sneeze because when you sneeze,your heart sto",
                "People-say-Bless-you-when-you-sneeze-because-when-you-sneeze-your-heart-sto",
                "People say 'Bless you' when you sneeze because when you sneeze,your heart stops for a mili-second.",
                "Misc"
              ),
              new FactModel(
                276,
                "Debra Winger was the voice of E.T.",
                "Debra-Winger-was-the-voice-of-E-T",
                "Debra Winger was the voice of E.T.",
                "Entertainment"
              ),
              new FactModel(
                277,
                "Leonardo da Vinci could write with one hand and draw with the other at the sa",
                "Leonardo-da-Vinci-could-write-with-one-hand-and-draw-with-the-other-at-the-sa",
                "Leonardo da Vinci could write with one hand and draw with the other at the same time.",
                "Entertainment"
              ),
              new FactModel(
                278,
                "The average person spends 6 months of their life sitting at red lights.",
                "The-average-person-spends-6-months-of-their-life-sitting-at-red-lights",
                "The average person spends 6 months of their life sitting at red lights.",
                "Misc"
              ),
              new FactModel(
                279,
                "Rats multiply so quickly that in 18 months, two rats could have over a millio",
                "Rats-multiply-so-quickly-that-in-18-months-two-rats-could-have-over-a-millio",
                "Rats multiply so quickly that in 18 months, two rats could have over a million descendants.",
                "Animal"
              ),
              new FactModel(
                280,
                "40% of McDonald's profits come from the sales of Happy Meals.",
                "40-of-McDonald-s-profits-come-from-the-sales-of-Happy-Meals",
                "40% of McDonald's profits come from the sales of Happy Meals.",
                "Misc"
              ),
              new FactModel(
                281,
                "Astronauts are not allowed to eat beans before they go into space because pas",
                "Astronauts-are-not-allowed-to-eat-beans-before-they-go-into-space-because-pas",
                "Astronauts are not allowed to eat beans before they go into space because passing wind in a space suit damages them.",
                "Misc"
              ),
              new FactModel(
                282,
                "During the chariot scene in 'Ben Hur' a small red car can be seen in the dist",
                "During-the-chariot-scene-in-Ben-Hur-a-small-red-car-can-be-seen-in-the-dist",
                "During the chariot scene in 'Ben Hur' a small red car can be seen in the distance.",
                "Entertainment"
              ),
              new FactModel(
                283,
                "Mel Blanc (the voice of Bugs Bunny) was allergic to carrots.",
                "Mel-Blanc-the-voice-of-Bugs-Bunny-was-allergic-to-carrots",
                "Mel Blanc (the voice of Bugs Bunny) was allergic to carrots.",
                "Entertainment"
              ),
              new FactModel(
                284,
                "Most lipstick contains fish scales.",
                "Most-lipstick-contains-fish-scales",
                "Most lipstick contains fish scales.",
                "Misc"
              ),
              new FactModel(
                285,
                "A cockroach can live several weeks with its head cut off.",
                "A-cockroach-can-live-several-weeks-with-its-head-cut-off",
                "A cockroach can live several weeks with its head cut off.",
                "Animal"
              ),
              new FactModel(
                286,
                "Seattle’s Fremont Bridge rises up and down more than any drawbridge in the wo",
                "Seattle’s-Fremont-Bridge-rises-up-and-down-more-than-any-drawbridge-in-the-wo",
                "Seattle’s Fremont Bridge rises up and down more than any drawbridge in the world.",
                "Misc"
              ),
              new FactModel(
                287,
                "Camels have three eyelids to protect themselves from blowing sand.",
                "Camels-have-three-eyelids-to-protect-themselves-from-blowing-sand",
                "Camels have three eyelids to protect themselves from blowing sand.",
                "Animal"
              ),
              new FactModel(
                288,
                "When you tie a noose, the rope is wrapped twelve times around because it's th",
                "When-you-tie-a-noose-the-rope-is-wrapped-twelve-times-around-because-it-s-th",
                "When you tie a noose, the rope is wrapped twelve times around because it's the same length as a persons head.",
                "Misc"
              ),
              new FactModel(
                289,
                "To escape the grip of a crocodile's jaws, push your thumbs into its eyeballs",
                "To-escape-the-grip-of-a-crocodile-s-jaws-push-your-thumbs-into-its-eyeballs",
                "To escape the grip of a crocodile's jaws, push your thumbs into its eyeballs - it will let you go instantly.",
                "Animal"
              ),
              new FactModel(
                290,
                "All 50 states are listed across the top of the Lincoln Memorial on the back o",
                "All-50-states-are-listed-across-the-top-of-the-Lincoln-Memorial-on-the-back-o",
                "All 50 states are listed across the top of the Lincoln Memorial on the back of the $5 bill.",
                "Misc"
              ),
              new FactModel(
                291,
                "The dot over the letter 'i' is called a tittle.",
                "The-dot-over-the-letter-i-is-called-a-tittle",
                "The dot over the letter 'i' is called a tittle.",
                "Word & Language"
              ),
              new FactModel(
                292,
                "The very first bomb dropped by the Allies on Berlin during World War II Kille",
                "The-very-first-bomb-dropped-by-the-Allies-on-Berlin-during-World-War-II-Kille",
                "The very first bomb dropped by the Allies on Berlin during World War II Killed the only elephant in the Berlin Zoo.",
                "Misc"
              ),
              new FactModel(
                293,
                "Ostriches are often not taken seriously. They can run faster than horses, and",
                "Ostriches-are-often-not-taken-seriously-They-can-run-faster-than-horses-and",
                "Ostriches are often not taken seriously. They can run faster than horses, and the males can roar like lions.",
                "Animal"
              ),
              new FactModel(
                294,
                "A 'jiffy' is a unit of time for 1/100th of a second.",
                "A-jiffy-is-a-unit-of-time-for-1-100th-of-a-second",
                "A 'jiffy' is a unit of time for 1/100th of a second.",
                "Science & Technology"
              ),
              new FactModel(
                295,
                "More Monopoly money is printed in a year, than real money throughout the worl",
                "More-Monopoly-money-is-printed-in-a-year-than-real-money-throughout-the-worl",
                "More Monopoly money is printed in a year, than real money throughout the world.",
                "Misc"
              ),
              new FactModel(
                296,
                "A cat has 32 muscles in each ear.",
                "A-cat-has-32-muscles-in-each-ear",
                "A cat has 32 muscles in each ear.",
                "Animal"
              ),
              new FactModel(
                297,
                "The world's youngest parents were 8 and 9 and lived in China in 1910.",
                "The-world-s-youngest-parents-were-8-and-9-and-lived-in-China-in-1910",
                "The world's youngest parents were 8 and 9 and lived in China in 1910.",
                "Misc"
              ),
              new FactModel(
                298,
                "A biological reserve has been made for golden toads because they are so rare.",
                "A-biological-reserve-has-been-made-for-golden-toads-because-they-are-so-rare",
                "A biological reserve has been made for golden toads because they are so rare.",
                "Animal"
              ),
              new FactModel(
                299,
                "A pregnant goldfish is called a twit.",
                "A-pregnant-goldfish-is-called-a-twit",
                "A pregnant goldfish is called a twit.",
                "Animal"
              ),
              new FactModel(
                300,
                "There is a city called Rome on every continent.",
                "There-is-a-city-called-Rome-on-every-continent",
                "There is a city called Rome on every continent.",
                "Misc"
              ),
              new FactModel(
                301,
                "The name Jeep came from the abbreviation used in the army for the 'General Pu",
                "The-name-Jeep-came-from-the-abbreviation-used-in-the-army-for-the-General-Pu",
                "The name Jeep came from the abbreviation used in the army for the 'General Purpose' vehicle, G.P.",
                "Misc"
              ),
              new FactModel(
                302,
                "Cat's urine glows under a black light.",
                "Cat-s-urine-glows-under-a-black-light",
                "Cat's urine glows under a black light.",
                "Misc"
              ),
              new FactModel(
                303,
                "A rat can last longer without water than a camel.",
                "A-rat-can-last-longer-without-water-than-a-camel",
                "A rat can last longer without water than a camel.",
                "Animal"
              ),
              new FactModel(
                304,
                "In the TV series I Love Lucy, Ricki Ricardo never actually said 'Lucy you hav",
                "In-the-TV-series-I-Love-Lucy-Ricki-Ricardo-never-actually-said-Lucy-you-hav",
                "In the TV series I Love Lucy, Ricki Ricardo never actually said 'Lucy you have some 'splaining to do'",
                "Entertainment"
              ),
              new FactModel(
                305,
                "Peanuts are one of the ingredients of dynamite.",
                "Peanuts-are-one-of-the-ingredients-of-dynamite",
                "Peanuts are one of the ingredients of dynamite.",
                "Misc"
              ),
              new FactModel(
                306,
                "Almonds are members of the peach family.",
                "Almonds-are-members-of-the-peach-family",
                "Almonds are members of the peach family.",
                "Misc"
              ),
              new FactModel(
                307,
                "Rats and horses can't vomit.",
                "Rats-and-horses-can-t-vomit",
                "Rats and horses can't vomit.",
                "Animal"
              ),
              new FactModel(
                308,
                "Nutmeg is extremely poisonous if injected intravenously.",
                "Nutmeg-is-extremely-poisonous-if-injected-intravenously",
                "Nutmeg is extremely poisonous if injected intravenously.",
                "Science & Technology"
              ),
              new FactModel(
                309,
                "Sherlock Holmes never said 'Elementary, my dear Watson'.",
                "Sherlock-Holmes-never-said-Elementary-my-dear-Watson",
                "Sherlock Holmes never said 'Elementary, my dear Watson'.",
                "Entertainment"
              ),
              new FactModel(
                310,
                "The microwave was invented after a researcher walked by a radar tube and a ch",
                "The-microwave-was-invented-after-a-researcher-walked-by-a-radar-tube-and-a-ch",
                "The microwave was invented after a researcher walked by a radar tube and a chocolate bar melted in his pocket.",
                "Science & Technology"
              ),
              new FactModel(
                311,
                "Bill Gates' first business was Traff-O-Data, a company that created machines",
                "Bill-Gates-first-business-was-Traff-O-Data-a-company-that-created-machines",
                "Bill Gates' first business was Traff-O-Data, a company that created machines which recorded the number of cars passing a given point on a road.",
                "Science & Technology"
              ),
              new FactModel(
                312,
                "The giant red star Betelgeuse has a diameter larger than that of the Earth's",
                "The-giant-red-star-Betelgeuse-has-a-diameter-larger-than-that-of-the-Earth-s",
                "The giant red star Betelgeuse has a diameter larger than that of the Earth's orbit around the sun.",
                "Misc"
              ),
              new FactModel(
                313,
                "Months that begin on a Sunday will always have a 'Friday the 13th.'",
                "Months-that-begin-on-a-Sunday-will-always-have-a-Friday-the-13th",
                "Months that begin on a Sunday will always have a 'Friday the 13th.'",
                "Misc"
              ),
              new FactModel(
                314,
                "More than 50% of the people in the world have never made or received a teleph",
                "More-than-50-of-the-people-in-the-world-have-never-made-or-received-a-teleph",
                "More than 50% of the people in the world have never made or received a telephone call.",
                "Human"
              ),
              new FactModel(
                315,
                "When Heinz ketchup leaves the bottle, it travels at a rate of 25 miles per ye",
                "When-Heinz-ketchup-leaves-the-bottle-it-travels-at-a-rate-of-25-miles-per-ye",
                "When Heinz ketchup leaves the bottle, it travels at a rate of 25 miles per year.",
                "Misc"
              ),
              new FactModel(
                316,
                "The average lead pencil will draw a line 35 miles long or write approximately",
                "The-average-lead-pencil-will-draw-a-line-35-miles-long-or-write-approximately",
                "The average lead pencil will draw a line 35 miles long or write approximately 50,000 English words.",
                "Misc"
              ),
              new FactModel(
                317,
                "The word 'queue' is the only word in the English language that is still prono",
                "The-word-queue-is-the-only-word-in-the-English-language-that-is-still-prono",
                "The word 'queue' is the only word in the English language that is still pronounced the same way when the last four letters are removed.",
                "Word & Language"
              ),
              new FactModel(
                318,
                "More people are killed each year from bees than from snakes.",
                "More-people-are-killed-each-year-from-bees-than-from-snakes",
                "More people are killed each year from bees than from snakes.",
                "Misc"
              ),
              new FactModel(
                319,
                "Many hamsters only blink one eye at a time.",
                "Many-hamsters-only-blink-one-eye-at-a-time",
                "Many hamsters only blink one eye at a time.",
                "Animal"
              ),
              new FactModel(
                320,
                "Nutmeg is extremely poisonous if injected intravenously.",
                "Nutmeg-is-extremely-poisonous-if-injected-intravenously",
                "Nutmeg is extremely poisonous if injected intravenously.",
                "Misc"
              ),
              new FactModel(
                321,
                "Leonardo Da Vinci invented scissors.",
                "Leonardo-Da-Vinci-invented-scissors",
                "Leonardo Da Vinci invented scissors.",
                "Misc"
              ),
              new FactModel(
                322,
                "On average, 12 newborns will be given to the wrong parents daily.",
                "On-average-12-newborns-will-be-given-to-the-wrong-parents-daily",
                "On average, 12 newborns will be given to the wrong parents daily.",
                "Misc"
              ),
              new FactModel(
                323,
                "Thirty-five percent of the people who use personal ads for dating are already",
                "Thirty-five-percent-of-the-people-who-use-personal-ads-for-dating-are-already",
                "Thirty-five percent of the people who use personal ads for dating are already married.",
                "Human"
              ),
              new FactModel(
                324,
                "The name Wendy was made up for the book Peter Pan, there was never a recorded",
                "The-name-Wendy-was-made-up-for-the-book-Peter-Pan-there-was-never-a-recorded",
                "The name Wendy was made up for the book Peter Pan, there was never a recorded Wendy before!",
                "Entertainment"
              ),
              new FactModel(
                325,
                "The radioactive substance, Americanium - 241 is used in many smoke detectors.",
                "The-radioactive-substance-Americanium--241-is-used-in-many-smoke-detectors",
                "The radioactive substance, Americanium - 241 is used in many smoke detectors.",
                "Science & Technology"
              ),
              new FactModel(
                326,
                "The only capital letter in the Roman alphabet with exactly one end point is P",
                "The-only-capital-letter-in-the-Roman-alphabet-with-exactly-one-end-point-is-P",
                "The only capital letter in the Roman alphabet with exactly one end point is P.",
                "Word & Language"
              ),
              new FactModel(
                327,
                "If you sneeze too hard, you can fracture a rib.",
                "If-you-sneeze-too-hard-you-can-fracture-a-rib",
                "If you sneeze too hard, you can fracture a rib.",
                "Human"
              ),
              new FactModel(
                328,
                "The Declaration of Independence was written on hemp paper.",
                "The-Declaration-of-Independence-was-written-on-hemp-paper",
                "The Declaration of Independence was written on hemp paper.",
                "Misc"
              ),
              new FactModel(
                329,
                "The worlds oldest piece of chewing gum is 9000 years old!",
                "The-worlds-oldest-piece-of-chewing-gum-is-9000-years-old",
                "The worlds oldest piece of chewing gum is 9000 years old!",
                "Misc"
              ),
              new FactModel(
                330,
                "You can tell the sex of a horse by its teeth. Most males have 40, females hav",
                "You-can-tell-the-sex-of-a-horse-by-its-teeth-Most-males-have-40-females-hav",
                "You can tell the sex of a horse by its teeth. Most males have 40, females have 36.",
                "Animal"
              ),
              new FactModel(
                331,
                "It’s against the law to burp, or sneeze in a church in Nebraska, USA.",
                "It’s-against-the-law-to-burp-or-sneeze-in-a-church-in-Nebraska-USA",
                "It’s against the law to burp, or sneeze in a church in Nebraska, USA.",
                "Misc"
              ),
              new FactModel(
                332,
                "A dragonfly has a lifespan of 24 hours.",
                "A-dragonfly-has-a-lifespan-of-24-hours",
                "A dragonfly has a lifespan of 24 hours.",
                "Animal"
              ),
              new FactModel(
                333,
                "The city with the most Roll Royces per capita: Hong Kong",
                "The-city-with-the-most-Roll-Royces-per-capita-Hong-Kong",
                "The city with the most Roll Royces per capita: Hong Kong",
                "Misc"
              ),
              new FactModel(
                334,
                "The only real person to be a Pez head was Betsy Ross.",
                "The-only-real-person-to-be-a-Pez-head-was-Betsy-Ross",
                "The only real person to be a Pez head was Betsy Ross.",
                "Misc"
              ),
              new FactModel(
                335,
                "A cat's jaw cannot move sideways.",
                "A-cat-s-jaw-cannot-move-sideways",
                "A cat's jaw cannot move sideways.",
                "Animal"
              ),
              new FactModel(
                336,
                "The cruise liner, Queen Elizabeth II, moves only six inches for each gallon o",
                "The-cruise-liner-Queen-Elizabeth-II-moves-only-six-inches-for-each-gallon-o",
                "The cruise liner, Queen Elizabeth II, moves only six inches for each gallon of diesel that it burns.",
                "Misc"
              ),
              new FactModel(
                337,
                "Maine is the only state whose name is just one syllable.",
                "Maine-is-the-only-state-whose-name-is-just-one-syllable",
                "Maine is the only state whose name is just one syllable.",
                "Misc"
              ),
              new FactModel(
                338,
                "Sound travels 15 times faster through steel than through the air.",
                "Sound-travels-15-times-faster-through-steel-than-through-the-air",
                "Sound travels 15 times faster through steel than through the air.",
                "Science & Technology"
              ),
              new FactModel(
                339,
                "In the United States, a pound of potato chips costs two hundred times more th",
                "In-the-United-States-a-pound-of-potato-chips-costs-two-hundred-times-more-th",
                "In the United States, a pound of potato chips costs two hundred times more than a pound of potatoes.  ",
                "Misc"
              ),
              new FactModel(
                340,
                "A raisin dropped in a glass of fresh champagne will bounce up and down contin",
                "A-raisin-dropped-in-a-glass-of-fresh-champagne-will-bounce-up-and-down-contin",
                "A raisin dropped in a glass of fresh champagne will bounce up and down continuously from the bottom of the glass to the top.",
                "Misc"
              ),
              new FactModel(
                341,
                "Donald Duck comics were banned from Finland because he doesn't wear trousers.",
                "Donald-Duck-comics-were-banned-from-Finland-because-he-doesn-t-wear-trousers",
                "Donald Duck comics were banned from Finland because he doesn't wear trousers.",
                "Entertainment"
              )
            };
            return facts;
        }

        public static FactModel GetFactOfTheDay()
        {
            return Facts.OrderBy(x => Guid.NewGuid()).First();
        }

        public static IEnumerable<FactModel> GetRandomFacts(int count = 10) =>
            Facts.OrderBy(x => Guid.NewGuid()).Take(count);

        public static IEnumerable<FactModel> GetCategoryFacts(string categoryName) =>
            Facts.Where(f => f.CategoryName == categoryName)
                .OrderBy(f => f.Id)
                .ToList();

        public static FactModel GetPrevFact(int factId, string category)
        {
            var query = FilteredFacts(category);

            var prevFact = query.OrderBy(f => f.Id)
                            .FirstOrDefault(q => q.Id < factId);
            return prevFact;
        }
        public static FactModel GetNextFact(int factId, string category)
        {
            var query = FilteredFacts(category);

            var nextFact = query.OrderBy(f => f.Id)
                            .FirstOrDefault(q => q.Id > factId); 
            return nextFact;
        }

        private static IEnumerable<FactModel> FilteredFacts(string category)
        {
            var query = Facts;
            if (!string.IsNullOrWhiteSpace(category) && category != CategoryModel.Random)
            {
                query = query.Where(q => q.CategoryName == category);
            }
            return query;
        }
    }
}
