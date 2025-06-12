import { Component, OnInit } from '@angular/core';
import { EpisodiosService, ApiResponse } from '../../services/episodios.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-episodios',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './episodios.component.html',
  styleUrl: './episodios.component.css',
})

export class EpisodiosComponent implements OnInit {

  episodios: any[] = [];
  paginaActual: number = 1;
  totalPaginas: number = 1;
  filtroTexto: string = '';
  episodiosFiltrados: any[] = [];


  constructor(private servicio: EpisodiosService) {}

  ngOnInit(): void {
    this.cargarEpisodios(this.paginaActual);
  }

  cargarEpisodios(pagina: number): void {
    this.servicio.obtenerEpisodios(pagina).subscribe({
      next: (res: ApiResponse) => {
        this.episodios = res.results;
        this.totalPaginas = res.info.pages ?? 1;
        this.paginaActual = pagina;
        this.filtrarEpisodios();
      },
      error: () => {
        alert('Error al cargar episodios.');
      }
    });
  }
  filtrarEpisodios(): void {
    const filtro = this.filtroTexto.toLowerCase();
    this.episodiosFiltrados = this.episodios.filter(e =>
      e.name.toLowerCase().includes(filtro) ||
      e.episode.toLowerCase().includes(filtro)
    );
  }


  siguientePagina(): void {
    if (this.paginaActual < this.totalPaginas) {
      this.cargarEpisodios(this.paginaActual + 1);
    }
  }

  anteriorPagina(): void {
    if (this.paginaActual > 1) {
      this.cargarEpisodios(this.paginaActual - 1);
    }
  }
}
