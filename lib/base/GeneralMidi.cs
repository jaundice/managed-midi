﻿using System;
namespace Commons.Music.Midi
{
	public class GeneralMidi 
	{
		public static readonly string [] InstrumentCategories = new string []
		{
			"Piano",
			"Chromatic Percussion",
			"Organ",
			"Guitar",
			"Bass",
			"Orchestra Solo",
			"Orchestra Ensemble",
			"Brass",
			"Reed",
			"Pipe",
			"Synth Lead",
			"Synth Pad",
			"Synth Sound FX",
			"Ethnic",
			"Percussive",
			"Sound Effect",
		};

		// Too lengthy to type "GeneralMidi.Instruments.AcousticGrandPiano" ?
		// Use "using static": using static GMInst = Commons.Music.Midi.GeneralMidi.Instruments;
		public static class Instruments 
		{
			public const byte AcousticGrandPiano = 0;
			public const byte BrightAcousticPiano = 1;
			public const byte ElectricGrandPiano = 2;
			public const byte HonkytonkPiano = 3;
			public const byte ElectricPiano1 = 4;
			public const byte ElectricPiano2 = 5;
			public const byte Harpsichord = 6;
			public const byte Clavi = 7;
			public const byte Celesta = 8;
			public const byte Glockenspiel = 9;
			public const byte MusicBox = 10;
			public const byte Vibraphone = 11;
			public const byte Marimba = 12;
			public const byte Xylophone = 13;
			public const byte TubularBells = 14;
			public const byte Dulcimer = 15;
			public const byte DrawbarOrgan = 16;
			public const byte PercussiveOrgan = 17;
			public const byte RockOrgan = 18;
			public const byte ChurchOrgan = 29;
			public const byte ReedOrgan = 20;
			public const byte Accordion = 21;
			public const byte Harmonica = 22;
			public const byte TangoAccordion = 23;
			public const byte AcousticGuitarNylon = 24;
			public const byte AcousticGuitarSteel = 25;
			public const byte ElectricGuitarJazz = 26;
			public const byte ElectricGuitarClean = 27;
			public const byte ElectricGuitarMuted = 28;
			public const byte OverdrivenGuitar = 29;
			public const byte DistortionGuitar = 30;
			public const byte Guitarharmonics = 31;
			public const byte AcousticBass = 32;
			public const byte ElectricBassFinger = 33;
			public const byte ElectricBassPick = 34;
			public const byte FretlessBass = 35;
			public const byte SlapBass1 = 36;
			public const byte SlapBass2 = 37;
			public const byte SynthBass1 = 38;
			public const byte SynthBass2 = 39;
			public const byte Violin = 40;
			public const byte Viola = 41;
			public const byte Cello = 42;
			public const byte Contrabass = 43;
			public const byte TremoloStrings = 44;
			public const byte PizzicatoStrings = 45;
			public const byte OrchestralHarp = 46;
			public const byte Timpani = 47;
			public const byte StringEnsemble1 = 48;
			public const byte StringEnsemble2 = 49;
			public const byte SynthStrings1 = 50;
			public const byte SynthStrings2 = 51;
			public const byte ChoirAahs = 52;
			public const byte VoiceOohs = 53;
			public const byte SynthVoice = 54;
			public const byte OrchestraHit = 55;
			public const byte Trumpet = 56;
			public const byte Trombone = 57;
			public const byte Tuba = 58;
			public const byte MutedTrumpet = 59;
			public const byte FrenchHorn = 60;
			public const byte BrassSection = 61;
			public const byte SynthBrass1 = 62;
			public const byte SynthBrass2 = 63;
			public const byte SopranoSax = 64;
			public const byte AltoSax = 65;
			public const byte TenorSax = 66;
			public const byte BaritoneSax = 67;
			public const byte Oboe = 68;
			public const byte EnglishHorn = 69;
			public const byte Bassoon = 70;
			public const byte Clarinet = 71;
			public const byte Piccolo = 72;
			public const byte Flute = 73;
			public const byte Recorder = 74;
			public const byte PanFlute = 75;
			public const byte BlownBottle = 76;
			public const byte Shakuhachi = 77;
			public const byte Whistle = 78;
			public const byte Ocarina = 79;
			public const byte LeadSquare = 80;
			public const byte LeadSawtooth = 81;
			public const byte LeadCalliope = 82;
			public const byte LeadChiff = 83;
			public const byte LeadCharang = 84;
			public const byte LeadVoice = 85;
			public const byte LeadFifths = 86;
			public const byte LeadBassAndLead = 87;
			public const byte PadNewage = 88;
			public const byte PadWarm = 89;
			public const byte PadPolysynth = 90;
			public const byte PadChoir = 91;
			public const byte PadBowed = 92;
			public const byte PadMetallic = 93;
			public const byte PadHalo = 94;
			public const byte PadSweep = 95;
			public const byte FXRain = 96;
			public const byte FXSoundtrack = 97;
			public const byte FXCrystal = 98;
			public const byte FXAtmosphere = 99;
			public const byte FXBrightness = 100;
			public const byte FXGoblins = 101;
			public const byte FXEchoes = 102;
			public const byte FXScifi = 103;
			public const byte Sitar = 104;
			public const byte Banjo = 105;
			public const byte Shamisen = 106;
			public const byte Koto = 107;
			public const byte Kalimba = 108;
			public const byte Bagpipe = 109;
			public const byte Fiddle = 110;
			public const byte Shanai = 111;
			public const byte TinkleBell = 112;
			public const byte Agogo = 113;
			public const byte SteelDrums = 114;
			public const byte Woodblock = 115;
			public const byte TaikoDrum = 116;
			public const byte MelodicTom = 117;
			public const byte SynthDrum = 118;
			public const byte ReverseCymbal = 119;
			public const byte GuitarFretNoise = 120;
			public const byte BreathNoise = 121;
			public const byte Seashore = 122;
			public const byte BirdTweet = 123;
			public const byte TelephoneRing = 124;
			public const byte Helicopter = 125;
			public const byte Applause = 126;
			public const byte Gunshot = 127;
		}

		public static class Percussions
		{
			public const byte AcousticBassDrum = 34;
			public const byte BassDrum1 = 35;
			public const byte SideStick = 36;
			public const byte AcousticSnare = 37;
			public const byte HandClap = 38;
			public const byte ElectricSnare = 39;
			public const byte LowFloorTom = 40;
			public const byte ClosedHiHat = 41;
			public const byte HighFloorTom = 42;
			public const byte PedalHiHat = 43;
			public const byte LowTom = 44;
			public const byte OpenHiHat = 45;
			public const byte LowMidTom = 46;
			public const byte HiMidTom = 47;
			public const byte CrashCymbal1 = 48;
			public const byte HighTom = 49;
			public const byte RideCymbal1 = 50;
			public const byte ChineseCymbal = 51;
			public const byte RideBell = 52;
			public const byte Tambourine = 53;
			public const byte SplashCymbal = 54;
			public const byte Cowbell = 55;
			public const byte CrashCymbal2 = 56;
			public const byte Vibraslap = 57;
			public const byte RideCymbal2 = 58;
			public const byte HiBongo = 59;
			public const byte LowBongo = 60;
			public const byte MuteHiConga = 61;
			public const byte OpenHiConga = 62;
			public const byte LowConga = 63;
			public const byte HighTimbale = 64;
			public const byte LowTimbale = 65;
			public const byte HighAgogo = 66;
			public const byte LowAgogo = 67;
			public const byte Cabasa = 68;
			public const byte Maracas = 69;
			public const byte ShortWhistle = 70;
			public const byte LongWhistle = 71;
			public const byte ShortGuiro = 72;
			public const byte LongGuiro = 73;
			public const byte Claves = 74;
			public const byte HiWoodBlock = 75;
			public const byte LowWoodBlock = 76;
			public const byte MuteCuica = 77;
			public const byte OpenCuica = 78;
			public const byte MuteTriangle = 79;
			public const byte OpenTriangle = 80;
		}
	}
}
