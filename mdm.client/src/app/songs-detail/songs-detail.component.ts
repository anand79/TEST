import { Component } from '@angular/core';


interface ISongDetail {
  songId: number;
  name: string;
  artist: string;
  album: string;
}

@Component({
  selector: 'app-songs-detail',
  templateUrl: './songs-detail.component.html',
  styleUrl: './songs-detail.component.css'
})
export class SongsDetailComponent {
  pageTitle = 'Songs Detail';
  product: ISongDetail | undefined;
}
