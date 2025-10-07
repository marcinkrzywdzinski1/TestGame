# Struktura projektu Unity dla gry mobilnej

Repozytorium zawiera podstawowy szkielet projektu Unity przygotowany pod grę mobilną. W katalogu znajdują się najważniejsze foldery wykorzystywane podczas produkcji, w tym miejsce na skrypty, sceny, zasoby graficzne oraz ustawienia projektu.

## Kluczowe elementy

- `Assets/` – główny katalog zasobów projektu.
  - `Scripts/` – logika gry napisana w C#. Przykładowy skrypt `GameManager.cs` ustawia orientację ekranu na pionową i ogranicza liczbę klatek na sekundę do 60.
  - `Scenes/` – miejsce na sceny gry (`.unity`).
  - `Prefabs/`, `Materials/`, `Textures/`, `Audio/`, `UI/` – foldery na często wykorzystywane typy zasobów.
- `ProjectSettings/` – konfiguracja projektu Unity (wymagane przez edytor).
- `Packages/` – konfiguracja pakietów Unity Package Manager.

## Kolejne kroki

1. Otwórz projekt w Unity (2021.3 lub nowszym) wskazując na katalog repozytorium.
2. Utwórz sceny i zasoby zgodnie z potrzebami projektu, pamiętając o mobilnych ograniczeniach wydajności.
3. Skonfiguruj ustawienia mobilne w `ProjectSettings`, w szczególności docelowe platformy (Android/iOS) i jakość grafiki.

Repozytorium stanowi punkt startowy do dalszego rozwijania gry.
