class Jogador {
    constructor(elementId, startX = 0, startY = 0) {
        this.el = document.getElementById(elementId);
        this.x = startX;
        this.y = startY;
        this.step = 10;
        this.raio = 25;
        this.campo = document.querySelector(".field-game");
        this.campoWidth = this.campo.clientWidth;
        this.campoHeight = this.campo.clientHeight;
        this.centroX = this.campoWidth / 2;
        this.centroY = this.campoHeight / 2;

        // Cria a label de posição
        this.label = document.createElement("div");
        this.label.style.position = "absolute";
        this.label.style.color = "white";
        this.label.style.fontWeight = "bold";
        this.label.style.fontSize = "12px";
        this.label.style.textShadow = "0 0 3px black";
        this.campo.appendChild(this.label);

        this.atualizarPosicao();
    }

    mover(tecla) {
        switch (tecla) {
            case "ArrowUp": this.y -= this.step; break;
            case "ArrowDown": this.y += this.step; break;
            case "ArrowLeft": this.x -= this.step; break;
            case "ArrowRight": this.x += this.step; break;
        }
        this.atualizarPosicao();
    }

    atualizarPosicao() {
        const telaX = this.centroX + this.x - this.raio;
        const telaY = this.centroY + this.y - this.raio;

        // Move o jogador
        this.el.style.position = "absolute";
        this.el.style.left = `${telaX}px`;
        this.el.style.top = `${telaY}px`;

        // Atualiza e posiciona a label um pouco acima do jogador
        this.label.textContent = `x: ${this.x} y: ${this.y}`;
        this.label.style.left = `${telaX}px`;
        this.label.style.top = `${telaY - 20}px`; // 20px acima do jogador
    }
}

// Inicializa com a posição (0, -340)
const jogador1 = new Jogador("player-1", -340, 0);

document.addEventListener("keydown", (e) => {
    jogador1.mover(e.key);
});
