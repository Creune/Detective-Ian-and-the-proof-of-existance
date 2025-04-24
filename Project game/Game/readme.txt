A készülő játék egy murder mystery stílusú, clue-hoz hasonló játék lesz, ahol a player a detektív aki kideríti melyik npc a gyilkos.

A játék jelenlegi állapotában van:
player tud mozogni, a gyilkos szerepét egyenlőre defaultként a hatszög kapja a tesztelés megkönnyítésének érdekében, ezek bizonyos kijelölt célpontok kötzött tudnak mozogni navmesh-el. Ha a gyilkos megöl valakit, azt érzékeli a kód de még nem csinál vele semmit (Debug Logként kiírja de az a kibuildelt verzióban nem látható, mint amikor a gyilkos fegyvert vesz fel vagy megöl valakit bár ezek implementálva is vannak. A háttérben a játék azt is számon tartja ki melyik szobában van de ez egyáltalán nem látható a buildben mert háttérinformáció)

Ami még lesz bele:
UI elemek, grafikai mód váltása és grafika implementálása(a jelenlegi színek a developmentben segítenek helységeket, falakat és bútorokat elkülöníteni egymástól, a grafikával azok is lecserélésre kerülnek majd), a játékos képes legyen a gyilkost felfedni, win/lose gamestate, az áldozatok megvizsgálásából információ kinyerése, kilépés lehetősége(egyenlőre alt+f4), bugixes.

-Lilla