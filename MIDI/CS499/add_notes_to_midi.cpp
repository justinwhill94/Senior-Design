//#ifdef WIN32
//#include <windows.h>
//#endif

#include "jdksmidi/world.h"
#include "jdksmidi/track.h"
#include "jdksmidi/multitrack.h"
#include "jdksmidi/filereadmultitrack.h"
#include "jdksmidi/fileread.h"
#include "jdksmidi/fileshow.h"
#include "jdksmidi/filewritemultitrack.h"
using namespace jdksmidi;

#include <iostream>
#include <vector>
#include <string>
using namespace std;

void add_notes_to_midi(vector<int>* &note_array, MIDITimedBigMessage &m, MIDIMultiTrack &tracks, int &trk, MIDIClockTime &t, MIDIClockTime &dt, unsigned char &chan, unsigned char &note, unsigned char &velocity, unsigned char &ctrl, unsigned char &val) {
	
	// create individual midi events with the MIDITimedBigMessage and add them to a track 1

	t = 0;

	// we add note 1: press and release in (dt) ticks

	m.SetTime(t);
	m.SetNoteOn(chan = 0, note = 60, velocity = 100);
	tracks.GetTrack(trk)->PutEvent(m);

	// after note(s) on before note(s) off: add words to music in the present situation
	tracks.GetTrack(trk)->PutTextEvent(t, META_LYRIC_TEXT, "Left");

	m.SetTime(t += dt);
	m.SetNoteOff(chan, note, velocity);
	// alternative form of note off event: useful to reduce midifile size if running status is used (on default so)
	// m.SetNoteOn( chan, note, 0 );
	tracks.GetTrack(trk)->PutEvent(m);

	// note 2

	m.SetNoteOn(chan = 1, note = 64, velocity);
	tracks.GetTrack(trk)->PutEvent(m);

	tracks.GetTrack(trk)->PutTextEvent(t, META_LYRIC_TEXT, "Centre");

	m.SetTime(t += dt);
	m.SetNoteOff(chan, note, velocity);
	tracks.GetTrack(trk)->PutEvent(m);

	// note 3

	m.SetNoteOn(chan = 2, note = 67, velocity);
	tracks.GetTrack(trk)->PutEvent(m);

	tracks.GetTrack(trk)->PutTextEvent(t, META_LYRIC_TEXT, "Right");

	m.SetTime(t += dt);
	m.SetNoteOff(chan, note, velocity);
	tracks.GetTrack(trk)->PutEvent(m);

	// add pause

	t += dt;

	// add chord: 3 notes simultaneous

	// press
	m.SetTime(t);
	m.SetNoteOn(chan = 0, note = 60, velocity);
	tracks.GetTrack(trk)->PutEvent(m);
	m.SetNoteOn(chan = 1, note = 64, velocity);
	tracks.GetTrack(trk)->PutEvent(m);
	m.SetNoteOn(chan = 2, note = 67, velocity);
	tracks.GetTrack(trk)->PutEvent(m);

	tracks.GetTrack(trk)->PutTextEvent(t, META_LYRIC_TEXT, "Chord");

	// release
	m.SetTime(t += (2 * dt));
	m.SetNoteOff(chan = 0, note = 60, velocity);
	tracks.GetTrack(trk)->PutEvent(m);
	m.SetNoteOff(chan = 1, note = 64, velocity);
	tracks.GetTrack(trk)->PutEvent(m);
	m.SetNoteOff(chan = 2, note = 67, velocity);
	tracks.GetTrack(trk)->PutEvent(m);

	// add pause: press note with velocity = 0 equivalent to simultaneous release it

	t += dt;
	m.SetTime(t);
	m.SetNoteOn(chan = 0, note = 0, velocity = 0);
	tracks.GetTrack(trk)->PutEvent(m);
}