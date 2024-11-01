import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Song {
  songId: number;
  name: string;
  artist: string;
  album: string;
}

@Component({
  selector: 'app-songs',
  templateUrl: './songs.component.html',
  styleUrl: './songs.component.css'
})

export class SongsComponent implements OnInit {
  
  public songs: Song[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit() {   
    this.getSongs();
  }
 

  getSongs() {
    this.http.get<Song[]>('/getSongs').subscribe(
      (result) => {
        console.log(result);
        this.songs = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  editItem(item: any) {
    // Open item-form component for editing
  }

  deleteItem(id: number) {
    //this.songs.deleteItem(id);
    this.songs = this.songs.filter(i => i.songId !== id);
  }

  title = 'mdm.client';
}
